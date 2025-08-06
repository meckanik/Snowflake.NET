using System.Globalization;
using System.Text;
using Snowflake.NET.Attributes;
using Snowflake.NET.Helpers;
using Snowflake.NET.Models.DAO;

namespace Snowflake.NET.Scaffold.Scaffolding;

/// <summary>
///     Contains methods for generating POCO properties.
/// </summary>
public static class PropertyGenerator
{
    private const string getterAndSetter = " { get; set; }\r\n";
    private const string nullable = "?";
    private const string SPC = " ";

    private static readonly IFormatProvider _provider = CultureInfo.InvariantCulture;

    /// <summary>
    ///     Generates a single POCO property from table column data.
    /// </summary>
    /// <param name="column">The <see cref="InformationColumn"/> object, containing the property values.</param>
    /// <returns>The constructed property as a string.</returns>
    public static string Generate(InformationColumn? column)
    {
        var sb = new StringBuilder();
        if (column is not null && !string.IsNullOrEmpty(column.DATA_TYPE) && !string.IsNullOrEmpty(column.COLUMN_NAME))
        {
            var rawName = column.COLUMN_NAME;
            var formattedName = Transforms.TransformLabel(rawName);

            sb.AppendLine(GenerateComment(rawName));
            sb.AppendLine(GeneratePropertyAttribute(rawName));

            if (string.Equals(column.IS_NULLABLE, "TRUE", StringComparison.Ordinal))
            {
                sb.AppendLine(_provider,
                    $"\tpublic{SPC}{TypeMapper.Map(column.DATA_TYPE)}{nullable}{SPC}{formattedName}{SPC}{getterAndSetter}");
            }
            else
            {
                // TODO - add default values for non-nullable types
                sb.AppendLine(_provider,
                    $"\tpublic{SPC}{TypeMapper.Map(column.DATA_TYPE)}{nullable}{SPC}{formattedName}{SPC}{getterAndSetter}");
            }
        }

        return sb.ToString();
    }

    private static string GenerateComment(string propertyName)
    {
        return "\t/// <summary>\r\n" +
            $"\t///\tGets or sets the {propertyName} value.\r\n" +
            "\t/// </summary>";
    }

    private static string GeneratePropertyAttribute(string rawPropertyName)
    {
        var attribute = typeof(PropertyNameAttribute).Name.Replace("Attribute", "", StringComparison.OrdinalIgnoreCase);
        return $"\t[{attribute}(\"{rawPropertyName}\")]";
    }
}
