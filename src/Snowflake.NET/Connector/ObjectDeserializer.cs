using System.Reflection;
using Newtonsoft.Json;
using Snowflake.NET.Attributes;
using Snowflake.NET.Constants;
using Snowflake.NET.Helpers;

namespace Snowflake.NET.Connector;

/// <summary>
///     Deserializes string data from the Snowflake API into an object specified by the type parameter.
/// </summary>
/// <typeparam name="T">The target object type.</typeparam>
/// <param name="properties">The collection of table column names.</param>
public class ObjectDeserializer<T>(IEnumerable<string> properties)
{
    private readonly List<string> _dbProperties = [.. properties];

    /// <summary>
    ///     Deserializes a string value, representing a row of data, into the specified object.
    /// </summary>
    /// <param name="data">The row of data from the Snowflake API.</param>
    /// <returns>An instance of <see cref="{T}"/></returns>
    public T Deserialize(string data)
    {
        var values = data.Split(JsonConstants.Seperator);
        var propertyValueDictionary = new Dictionary<string, string>();
        for (var indx = 0; indx < _dbProperties?.Count; indx++)
        {
            propertyValueDictionary.Add(_dbProperties[indx], values[indx]);
        }

        var result = Activator.CreateInstance(typeof(T));

        // check for generated class
        if (typeof(T).GetCustomAttribute<TableNameAttribute>() is null)
        {
            var json = JsonConvert.SerializeObject(propertyValueDictionary);
            result = JsonConvert.DeserializeObject<T>(json);
        }
        else
        {
            foreach (var prop in result?.GetType().GetProperties().ToList()!)
            {
                var dbProp = _dbProperties!.FirstOrDefault(db => Transforms.TransformLabel(db) == prop.Name);

                propertyValueDictionary.TryGetValue(dbProp!, out var value);

                if (prop.PropertyType.Name.Contains("Nullable", StringComparison.OrdinalIgnoreCase))
                {
                    if (value is not null && value != string.Empty)
                    {
                        var underlyingType = Nullable.GetUnderlyingType(prop.PropertyType);
                        var typedValue = Convert.ChangeType(value, underlyingType!);

                        prop.SetValue(result, typedValue, null);
                    }
                }
                else
                {
                    var typedValue = Convert.ChangeType(value, prop.PropertyType!);
                    prop.SetValue(result, typedValue, null);
                }
            }
        }

        return (T)result!;
    }
}
