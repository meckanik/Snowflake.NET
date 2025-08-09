using System.Data;
using System.Text;
using Snowflake.NET.Connector;
using Snowflake.NET.Constants;
using Snowflake.NET.Validation;

namespace Snowflake.NET.Framework.Snowflake;

/// <summary>
///     Contains methods for reading Snowflake API return data.
/// </summary>
public static class SnowflakeReader
{
    /// <summary>
    ///     Reads Snowflake API return data.
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
                var fieldCount = reader.FieldCount;
                var propList = new List<string>();

                for (var indx = 0; indx < fieldCount; indx++)
                {
                    propList.Add(reader.GetName(indx));
                }

                var builder = new ObjectDeserializer<T>(propList);
                while (reader.Read())
                {
                    var sb = new StringBuilder();
                    for (var indx = 0; indx < fieldCount; indx++)
                    {
                        sb.Append($"{reader.GetString(indx)}{JsonConstants.Seperator}");
                    }

                    result.Add(builder.Deserialize(sb.ToString()));
                }
            }
        }

        return result;
    }
}
