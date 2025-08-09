using System.Globalization;
using System.Text;
using Snowflake.NET.Attributes;
using Snowflake.NET.Helpers;
using Snowflake.NET.Models.DAO;

namespace Snowflake.NET.Scaffold.Scaffolding;

internal static class PropertyGenerator
{
    private const string getterAndSetter = " { get; set; }\r\n";
    private const string SPC = " ";

    private static readonly IFormatProvider _provider = CultureInfo.InvariantCulture;

    internal static string Generate(InformationColumn? column)
    {
        var sb = new StringBuilder();
        if (column is not null && !string.IsNullOrEmpty(column.DATA_TYPE) && !string.IsNullOrEmpty(column.COLUMN_NAME))
        {
            var rawName = column.COLUMN_NAME;
            var formattedName = Transforms.TransformLabel(rawName);

            sb.AppendLine(GenerateComment(rawName));
            sb.AppendLine(GeneratePropertyAttribute(rawName));

            var nullable = string.Equals(column.IS_NULLABLE, "TRUE", StringComparison.OrdinalIgnoreCase) ? string.Empty : "?";

            // TODO - add default values for non-nullable types
            var dataType = string.Empty;
            if (string.Equals(column.DATA_TYPE, "NUMBER", StringComparison.OrdinalIgnoreCase) && column.NUMERIC_SCALE > 0)
            {
                dataType = typeof(decimal).Name.ToUpperInvariant();
            }
            else
            {
                dataType = column.DATA_TYPE;
            }

            sb.AppendLine(_provider,
                $"\tpublic{SPC}{TypeMapper.Map(dataType)}{nullable}{SPC}{formattedName}{SPC}{getterAndSetter}");
        }

        return sb.ToString();
    }

    private static string GenerateComment(string propertyName)
    {
        var sb = new StringBuilder();
        sb.AppendLine("\t/// <summary>");
        sb.AppendLine($"\t///\tGets or sets the {propertyName} value.");
        sb.Append("\t/// </summary>");

        return sb.ToString();
    }

    private static string GeneratePropertyAttribute(string rawPropertyName)
    {
        var attribute = typeof(PropertyNameAttribute).Name.Replace("Attribute", "", StringComparison.OrdinalIgnoreCase);
        return $"\t[{attribute}(\"{rawPropertyName}\")]";
    }
}
