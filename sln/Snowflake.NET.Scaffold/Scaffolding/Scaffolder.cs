using System.Data;
using System.Globalization;
using System.Text;
using Snowflake.NET.Attributes;
using Snowflake.NET.Constants;
using Snowflake.NET.Scaffold.DTE;
using Snowflake.NET.Helpers;
using Snowflake.NET.Models.DAO;
using Snowflake.NET.Validation;
using Snowflake.Data.Client;
using Snowflake.Data.Core;

namespace Snowflake.NET.Scaffold.Scaffolding;

/// <summary>
///     Connects to a Snowflake database and scaffolds all of the required POCO and repository classes.
/// </summary>
public class Scaffolder
{
    private static readonly IFormatProvider _provider = CultureInfo.InvariantCulture;

    private readonly string _connectionString;
    private readonly string _repositoryNameSpace;
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
        _repositoryNameSpace = $"{rootNamespace}.SnowflakeRepository";
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

            cmd.CommandText = "select * from TABLES";
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

            // generate the class files
            GenerateClasses(tableContainerList);
            // refresh VS projects to see new files
            var vsInstances = DteInstances.GetInstances();
            DteAutomation.RefreshProjects(vsInstances);
        }

        conn.Close();

        return true;
    }

    private void GenerateClasses(IEnumerable<TableContainer> dbInfo)
    {
        PropertyValidators.ValidateArgument(dbInfo);

        if (dbInfo is not null)
        {
            foreach (var tableSchema in dbInfo.GroupBy(
                db => db.Schema,
                db => db,
                (key, data) => new { Schema = key, Data = data }).ToList())
            {
                // TODO - don't set this each time
                var rawDbName = tableSchema.Data.First().DatabaseName;
                var formattedDbName = Transforms.TransformLabel(rawDbName!);
                var rawSchemaName = tableSchema.Schema;
                var formattedSchemaName = Transforms.TransformLabel(rawSchemaName!);

                // we will update this for views, so make it a single-element array as strings are immutable
                var schemaPath = new string[] { Path.Combine(_repositoryPath, formattedDbName, formattedSchemaName) };
                if (!Directory.Exists(schemaPath[0]))
                {
                    Directory.CreateDirectory(schemaPath[0]);
                }

                var currentNamespace = string.Join('.', _repositoryNameSpace, formattedDbName, formattedSchemaName);

                // write out the table POCOs
                foreach (var table in tableSchema.Data.ToList())
                {
                    var viewPath = Path.Combine(schemaPath[0], "Views");
                    if (table.TableType == TableConstants.TableTypeView)
                    {
                        if (!Directory.Exists(viewPath))
                        {
                            Directory.CreateDirectory(viewPath);
                        }

                        schemaPath[0] = viewPath;
                    }

                    var sb = new StringBuilder();
                    var rawTableName = table.TableName;
                    var formattedTableName = Transforms.TransformLabel(rawTableName!);

                    sb.AppendLine(GenerateUsingStatements());
                    sb.AppendLine(_provider, $"namespace {currentNamespace};\r\n");

                    sb.AppendLine(GenerateClassComment(rawTableName!));
                    sb.AppendLine(GenerateClassAttribute(rawTableName!));
                    sb.AppendLine(_provider, $"public class {formattedTableName}");
                    sb.AppendLine("{");

                    foreach (var col in table.Columns.ToList())
                    {
                        sb.Append(PropertyGenerator.Generate(col));
                    }

                    var tmp = new string[] { sb.ToString() };
                    var indx = tmp[0].LastIndexOf('\n');
                    tmp[0] = tmp[0].Substring(0, indx);
                    indx = tmp[0].LastIndexOf('\r');
                    tmp[0] = tmp[0].Substring(0, indx);

                    sb = new StringBuilder(tmp[0]);
                    sb.AppendLine("}");

                    File.WriteAllText(Path.Combine(schemaPath[0], $"{formattedTableName}.cs"), sb.ToString(), Encoding.UTF8);
                }
            }
        }
    }

    private static string GenerateClassComment(string rawTableName)
    {
        return "/// <summary>\r\n" +
            $"///\tProperty class for the {rawTableName} table.\r\n" +
            "/// </summary>";
    }

    private static string GenerateClassAttribute(string rawTableName)
    {
        var attribute = typeof(TableNameAttribute).Name.Replace("Attribute", "", StringComparison.OrdinalIgnoreCase);
        return $"[{attribute}(\"{rawTableName}\")]";
    }

    private static string GenerateUsingStatements()
    {
        return "using MultiORM.Snowflake.Attributes;\r\n";
    }
}
