using System.Globalization;
using System.Text;
using Snowflake.NET.Attributes;
using Snowflake.NET.Constants;
using Snowflake.NET.Helpers;
using Snowflake.NET.Models;
using Snowflake.NET.Validation;

namespace Snowflake.NET.Scaffold.Scaffolding;

internal static class PocoGenerator
{
    private static readonly IFormatProvider _provider = CultureInfo.InvariantCulture;

    internal static void Generate(
    string repositoryPath,
    string repositoryNamespace,
    IEnumerable<TableData> dbInfo)
    {
        PropertyValidators.ValidateArgument(dbInfo);

        if (dbInfo is not null)
        {
            foreach (var tableSchema in dbInfo.ToList())
            {
                // TODO - don't set this each time
                var rawDbName = tableSchema.Data.First().DatabaseName;
                var formattedDbName = Transforms.TransformLabel(rawDbName!);
                var rawSchemaName = tableSchema.Schema;
                var formattedSchemaName = Transforms.TransformLabel(rawSchemaName!);

                // we will update this for views, so make it a single-element array as strings are immutable
                var schemaPath = new string[] { Path.Combine(repositoryPath, formattedDbName, formattedSchemaName) };
                if (!Directory.Exists(schemaPath[0]))
                {
                    Directory.CreateDirectory(schemaPath[0]);
                }

                var currentNamespace = string.Join('.', repositoryNamespace, formattedDbName, formattedSchemaName);

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
        var sb = new StringBuilder();
        sb.AppendLine("/// <summary>");
        sb.AppendLine($"///\t\tProperty class for the {rawTableName} table.");
        sb.Append("/// </summary>");

        return sb.ToString();
    }

    private static string GenerateClassAttribute(string rawTableName)
    {
        var attribute = typeof(TableNameAttribute).Name.Replace("Attribute", "", StringComparison.OrdinalIgnoreCase);
        return $"[{attribute}(\"{rawTableName}\")]";
    }

    private static string GenerateUsingStatements()
    {
        return new StringBuilder().AppendLine($"using {typeof(PropertyNameAttribute).Namespace};").ToString();
    }
}
