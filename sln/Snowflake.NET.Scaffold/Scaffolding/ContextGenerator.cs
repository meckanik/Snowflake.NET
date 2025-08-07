using System.Globalization;
using System.Text;
using Snowflake.NET.Framework.Context;
using Snowflake.NET.Framework.Entity;
using Snowflake.NET.Helpers;
using Snowflake.NET.Models;

namespace Snowflake.NET.Scaffold.Scaffolding;

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

    public static void Generate(
        string repositoryPath,
        string repositoryNamespace,
        IEnumerable<TableData> dbInfo)
    {
        _repositoryPath = repositoryPath;
        _repositoryNamespace = repositoryNamespace;

        var schemaData = GenerateSchemaContext(dbInfo);

        GenerateSfDbContext(schemaData);
    }

    private static IEnumerable<SchemaData> GenerateSchemaContext(IEnumerable<TableData> dbInfo)
    {
        var result = new List<SchemaData>();
        if (dbInfo is not null)
        {
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

                if (!Directory.Exists(dbContextPath))
                {
                    Directory.CreateDirectory(dbContextPath);
                }

                var sb = new StringBuilder();
                // set usings
                sb.AppendLine(GenerateSchemaUsingStatements(formattedSchemaName!));
                // namespace declaration
                if (string.IsNullOrEmpty(_dbContextNameSpace))
                {
                    _dbContextNameSpace = string.Join('.', _repositoryNamespace, _formattedDbName, "DbContext");
                }
                
                sb.AppendLine(_provider, $"namespace {_dbContextNameSpace};\r\n");
                // class declaration
                sb.AppendLine(GenerateSchemaClassComment(formattedSchemaName!));
                sb.AppendLine(_provider, $"public class {schemaContextName}");
                sb.AppendLine("{");
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
                    
                    var pluralTableName = PluralizeName(tableName!);
                    sb.AppendLine("\t/// <summary>");
                    sb.AppendLine($"\t///{ttab}Gets or sets the {pluralTableName} value.");
                    sb.AppendLine("\t/// </summary>");
                    sb.AppendLine($"\tpublic{SPC}{_dbSetName}<{tableName}>{nullable}{SPC}{pluralTableName}{SPC}{getterAndSetter}");

                    currentSchemaData.TableNameList.Add(new KeyValuePair<string, string>(pluralTableName, $"{tableNamespace}.{tableName}"));
                }

                var tmp = new string[] { sb.ToString() };
                var indx = tmp[0].LastIndexOf('\n');
                tmp[0] = tmp[0].Substring(0, indx);
                indx = tmp[0].LastIndexOf('\r');
                tmp[0] = tmp[0].Substring(0, indx);

                sb = new StringBuilder(tmp[0]);
                sb.AppendLine("}");

                File.WriteAllText(Path.Combine(dbContextPath, $"{schemaContextName}.cs"), sb.ToString(), Encoding.UTF8);

                result.Add(currentSchemaData);
            }
        }

        return result;
    }

    private static void GenerateSfDbContext(IEnumerable<SchemaData> schemaData)
    {
        var sb = new StringBuilder();
        sb.AppendLine("using Snowflake.NET.Framework.Context;");
        sb.AppendLine("using Snowflake.NET.Framework.Entity;");
        sb.AppendLine($"using {_dbContextNameSpace};");
        // set the namespace
        sb.AppendLine(_provider, $"namespace {_repositoryNamespace};\r\n");
        // set the class comment
        sb.AppendLine("/// <summary>");
        sb.AppendLine("///\t\tContains the db schema context properties.");
        sb.AppendLine("/// </summary>");
        // set the class declaration
        var className = $"{_formattedDbName}Context";
        sb.AppendLine($"public class {className}");
        sb.AppendLine("{");
        // set the private property
        sb.AppendLine($"\tprivate readonly {typeof(SFContext).Name} _context;\r\n");
        // build the constructor
        sb.AppendLine("\t/// <summary>");
        sb.AppendLine($"\t///\t\tInitializes a new instance of the <see cref=\"{className}\"/> class.");
        sb.AppendLine("\t/// <summary>");
        sb.AppendLine($"\tpublic {className}({typeof(SFContext).Name} context)");
        sb.AppendLine("\t{");
        sb.AppendLine($"{ttab}_context = context;");
        sb.AppendLine("\t}\r\n");
        // write the properties
        foreach (var schema in schemaData)
        {
            sb.AppendLine("\t/// <summary>");
            sb.AppendLine($"\t///{ttab}Contains {_dbSetName} properties for tables within the {schema.SchemaName} schema.");
            sb.AppendLine("\t/// </summary>");
            sb.AppendLine($"\tpublic {schema.SchemaContextName} {schema.SchemaName} => new {schema.SchemaContextName}");
            sb.AppendLine("\t{");
            foreach (var table in schema.TableNameList)
            {
                sb.AppendLine($"\t{ttab}{table.Key} = new {_dbSetName}<{table.Value}>(_context),");
            }
            sb.AppendLine("};");
        }

        var tmp = new string[] { sb.ToString() };
        var indx = tmp[0].LastIndexOf('\n');
        tmp[0] = tmp[0].Substring(0, indx);
        indx = tmp[0].LastIndexOf('\r');
        tmp[0] = tmp[0].Substring(0, indx);

        sb = new StringBuilder(tmp[0]);
        sb.AppendLine("}");

        File.WriteAllText(Path.Combine(_repositoryPath, $"{_formattedDbName}Context.cs"), sb.ToString(), Encoding.UTF8);
    }

    private static string GenerateSchemaUsingStatements(string schemaName)
    {
        var sb = new StringBuilder();
        sb.AppendLine($"using {typeof(SFDbSet<>).Namespace};");
        sb.AppendLine($"using {_repositoryNamespace}.{_formattedDbName}.{schemaName};");

        return sb.ToString();
    }

    private static string GenerateSchemaClassComment(string schemaName)
    {
        var sb = new StringBuilder();
        sb.AppendLine("/// <summary>");
        sb.AppendLine($"///\t\tSF Schema Context class for the {schemaName} schema.");
        sb.Append("/// </summary>");

        return sb.ToString();
    }

    private static string PluralizeName(string name)
    {
        var result = new string[] { name };

        if (!string.Equals(name[name.Length - 1].ToString(), "S", StringComparison.OrdinalIgnoreCase))
        {
            result[0] = $"{result[0]}s";
        }

        return result[0];
    }
}

