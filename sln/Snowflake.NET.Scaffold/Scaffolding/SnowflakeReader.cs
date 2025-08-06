using System.Data;
using System.Globalization;
using System.Text;
using Newtonsoft.Json;
using Snowflake.NET.Validation;

namespace Snowflake.NET.Scaffold.Scaffolding;

/// <summary>
///     Reads Snowflake INFORMATION_SCHEMA data for scaffolding.
/// </summary>
public static class SnowflakeReader
{
    private static readonly IFormatProvider _provider = CultureInfo.InvariantCulture;

    /// <summary>
    ///     Reads Snowflake INFORMATION_SCHEMA data.
    /// </summary>
    /// <typeparam name="T">The object type parameter.</typeparam>
    /// <param name="cmd">The command text to execute.</param>
    /// <returns>A collection of <see cref="{T}"/></returns>
    public static IEnumerable<T> Read<T>(IDbCommand cmd)
    {
        PropertyValidators.ValidateArgument(cmd);

        var result = new List<T>();
        using (var reader = cmd?.ExecuteReader())
        {
            if (reader is not null)
            {
                while (reader.Read())
                {
                    var sb = new StringBuilder();
                    sb.Append("{ ");
                    var colCount = reader.FieldCount;
                    for (var indx = 0; indx < colCount; indx++)
                    {
                        var comma = indx + 1 == colCount ? string.Empty : ", ";
                        sb.Append(_provider, $"\"{reader.GetName(indx)}\":\"{reader[indx].ToString()}\"{comma}");
                    }

                    sb.Append(" }");

                    var info = JsonConvert.DeserializeObject<T>(sb.ToString());
                    if (info is not null)
                    {
                        result.Add(info);
                    }
                }
            }
        }

        return result;
    }
}
