using System.Globalization;
using Snowflake.NET.Framework.Context;
using Snowflake.NET.Framework.Entity;
using Snowflake.NET.Helpers;
using Snowflake.NET.Models;

namespace Snowflake.NET.Scaffold.Scaffolding;

/// <summary>
///     Contains scaffolding operation methods.
/// </summary>
internal static class ContextGenerator
{
    private const string getterAndSetter = " { get; set; }\r\n";
    private const string nullable = "?";
    private const string SPC = " ";
    private const string ttab = "\t\t";

    private static readonly IFormatProvider _provider = CultureInfo.InvariantCulture;
    
    private static string _repositoryPath = string.Empty;
    private static string _repositoryNamespace = string.Empty;
    private static string _dbContextNameSpace = string.Empty;
    private static string _formattedDbName = string.Empty;
    private static string _dbSetName = typeof(SFDbSet<>).Name.TrimEnd(['`', '1']);
    private static string _sfContextName = typeof(SFContext).Name;

    /// <summary>
    ///     Generates the context objects for scaffolding operations.
    /// </summary>
    /// <param name="repositoryPath">The physical location to place the generated files.</param>
    /// <param name="repositoryNamespace">The namespace to use for the generated files.</param>
    /// <param name="dbInfo">The INFORMATION_SCHEMA table information.</param>
    internal static void Generate(
        string repositoryPath,
        string repositoryNamespace,
        IEnumerable<TableData> dbInfo)
    {
        _repositoryPath = repositoryPath;
        _repositoryNamespace = repositoryNamespace;
        
        var schemaData = new List<SchemaData>();
        if (dbInfo is not null)
        {
            Writer? writer = null;
            string[]? usings = null;

            foreach (var tableSchema in dbInfo)
            {
                if (string.IsNullOrEmpty(_formattedDbName))
                {
                    _formattedDbName = Transforms.TransformLabel(tableSchema.Data.First().DatabaseName!);
                }

                var formattedSchemaName = Transforms.TransformLabel(tableSchema.Schema!);
                var dbContextPath = Path.Combine(_repositoryPath, _formattedDbName, "DbContext");
                var schemaContextName = $"{formattedSchemaName}Context";
                var currentSchemaData = new SchemaData()
                {
                    SchemaName = formattedSchemaName,
                    SchemaContextName = schemaContextName,
                };

                writer = new Writer(dbContextPath, schemaContextName);

                // set usings
                usings = new[]
                {
                    $"using {typeof(SFDbSet<>).Namespace};",
                    $"using {_repositoryNamespace}.{_formattedDbName}.{formattedSchemaName};\r\n"
                };
                writer.WriteUsings(usings);
                // namespace declaration
                if (string.IsNullOrEmpty(_dbContextNameSpace))
                {
                    _dbContextNameSpace = string.Join('.', _repositoryNamespace, _formattedDbName, "DbContext");
                }
                writer.Write($"namespace {_dbContextNameSpace};\r\n");
                // class declaration
                writer.WriteSummary($"SF Schema Context class for the {formattedSchemaName} schema.", false);
                writer.Write($"public class {schemaContextName}");
                writer.WriteOpenBracket(false);
                // write out the dbset properties
                var tableNamespace = string.Empty;
                foreach (var table in tableSchema.Data)
                {
                    var tableName = Transforms.TransformLabel(table.TableName!);
                    var schemaName = Transforms.TransformLabel(table.Schema!);
                    if (string.IsNullOrEmpty(tableNamespace))
                    {
                        tableNamespace = $"{_repositoryNamespace}.{_formattedDbName}.{schemaName}";
                    }

                    var pluralTableName = TextHelpers.PluralizeName(tableName!);

                    writer.WriteSummary($"Gets or sets the {pluralTableName} value.");
                    writer.Write($"\tpublic{SPC}{_dbSetName}<{tableName}>{nullable}{SPC}{pluralTableName}{SPC}{getterAndSetter}");

                    currentSchemaData.TableNameList.Add(new KeyValuePair<string, string>(pluralTableName, $"{tableNamespace}.{tableName}"));
                }

                writer.WriteToFile();

                schemaData.Add(currentSchemaData);
            }

            var contextName = $"{_formattedDbName}Context";
            writer = new Writer(_repositoryPath, contextName);

            // write usings
            usings = new[]
            {
                "using Snowflake.NET.Framework.Context;",
                "using Snowflake.NET.Framework.Entity;",
                $"using {_dbContextNameSpace};"
            };
            writer.WriteUsings(usings);
            // set the namespace
            writer.Write($"namespace {_repositoryNamespace};\r\n");
            // set the class comment
            writer.WriteSummary("Contains the db schema context properties.", false);
            // set the class declaration
            writer.Write($"public class {contextName}");
            writer.WriteOpenBracket(false);
            // set the private property
            writer.Write($"\tprivate readonly {_sfContextName} _context;\r\n");
            // build the constructor
            writer.WriteSummary($"Initializes a new instance of the <see cref=\"{contextName}\"/> class.");
            writer.Write($"\tpublic {contextName}({_sfContextName} context)");
            writer.Wrap("_context = context;", true, true);
            // write the properties
            foreach (var schema in schemaData)
            {
                writer.WriteSummary($"Contains {_dbSetName} properties for tables within the {schema.SchemaName} schema.");
                writer.Write($"\tpublic {schema.SchemaContextName} {schema.SchemaName} => new {schema.SchemaContextName}");
                writer.Wrap(schema.TableNameList.Select(tbl => 
                    new string($"\t{ttab}{tbl.Key} = new {_dbSetName}<{tbl.Value}>(_context),")), true, true);
            }

            writer.WriteToFile();
        }
    }
}

