using System.Data;
using System.Globalization;
using Snowflake.NET.Scaffold.DTE;
using Snowflake.NET.Models.DAO;
using Snowflake.NET.Validation;
using Snowflake.Data.Client;
using Snowflake.Data.Core;
using Snowflake.NET.Models;

namespace Snowflake.NET.Scaffold.Scaffolding;

/// <summary>
///     Connects to a Snowflake database and scaffolds all of the required POCO and repository classes.
/// </summary>
public class Scaffolder
{
    private static readonly IFormatProvider _provider = CultureInfo.InvariantCulture;

    private readonly string _connectionString;
    private readonly string _repositoryNamespace;
    private readonly string _repositoryPath;
    private readonly Dictionary<string, object> _namespaces;

    /// <summary>
    ///     Initializes a new instance of the <see cref="Scaffolder"/> class.
    /// </summary>
    /// <param name="connectionString">The database connection string.</param>
    /// <param name="rootNamespace">The root namespace of the target project.</param>
    /// <param name="path">The to create the scaffolded files in.</param>
    public Scaffolder(
        string connectionString,
        string rootNamespace,
        string path)
    {
        PropertyValidators.ValidateArgument(connectionString);
        PropertyValidators.ValidateArgument(rootNamespace);
        PropertyValidators.ValidateArgument(path);

        _connectionString = connectionString;
        _repositoryNamespace = $"{rootNamespace}.SnowflakeRepository";
        _repositoryPath = Path.Combine(path, "SnowflakeRepository");

        if (!Directory.Exists(_repositoryPath))
        {
            Directory.CreateDirectory(_repositoryPath);
        }

        _namespaces = [];
    }

    /// <summary>
    ///     Scaffolds the specified Snowflake database.
    /// </summary>
    /// <returns>True, if sucessful.</returns>
    public bool ScaffoldDatabase()
    {
        var tableContainerList = new List<TableContainer>();

        using IDbConnection conn = new SnowflakeDbConnection();

        conn.ConnectionString = _connectionString;
        conn.Open();

        using (var cmd = conn.CreateCommand())
        {
            cmd.CommandText = $"alter session set DOTNET_QUERY_RESULT_FORMAT = {ResultFormat.JSON}";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "select * from TABLES where TABLE_SCHEMA!='INFORMATION_SCHEMA'";
            cmd.CommandType = CommandType.Text;

            var tableList = SnowflakeReader.Read<InformationTable>(cmd);

            foreach (var table in tableList.Where(tbl => tbl.TABLE_SCHEMA != "INFORMATION_SCHEMA").ToList())
            {
                cmd.CommandText = $"select * from COLUMNS where TABLE_SCHEMA='{table.TABLE_SCHEMA}' and TABLE_NAME='{table.TABLE_NAME}'";
                cmd.CommandType = CommandType.Text;

                var columnList = SnowflakeReader.Read<InformationColumn>(cmd);

                tableContainerList.Add(new TableContainer
                {
                    DatabaseName = table.TABLE_CATALOG,
                    TableName = table.TABLE_NAME,
                    TableType = table.TABLE_TYPE,
                    Schema = table.TABLE_SCHEMA,
                    Columns = columnList
                });
            }

            // group the table list
            var grouped = tableContainerList.GroupBy(
                db => db.Schema,
                db => db,
                (key, data) => new TableData { Schema = key, Data = data });

            // generate the class files
            ClassGenerator.Generate(
                _repositoryPath, 
                _repositoryNamespace,
                grouped);


            // refresh VS projects to see new files
            var vsInstances = DteInstances.GetInstances();
            DteAutomation.RefreshProjects(vsInstances);
        }
        // close the connection
        conn.Close();

        return true;
    }
}
