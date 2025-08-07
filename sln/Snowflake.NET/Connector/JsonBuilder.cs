using Newtonsoft.Json;
using Snowflake.NET.Constants;

namespace Snowflake.NET.Connector;

/// <summary>
///     Handles processing of Snowflake API return data.
/// </summary>
/// <param name="properties">The collection of table column names.</param>
public class JsonBuilder(IEnumerable<string> properties)
{
    private readonly List<string> _properties = [.. properties];
    private readonly List<Dictionary<string, string>> _internalSet = [];

    /// <summary>
    ///     Adds a row of string data to the internal collection.
    /// </summary>
    /// <param name="row">The string data.</param>
    public void AddSerializedObject(string row)
    {
        var values = row.Split(JsonConstants.Seperator);
        var dict = new Dictionary<string, string>();
        for (var indx = 0; indx < _properties?.Count; indx++)
        {
            dict.Add(_properties[indx], values[indx]);
        }

        _internalSet.Add(dict);
    }

    /// <summary>
    ///     Returns the textual data in Json format.
    /// </summary>
    /// <returns>A Json string.</returns>
    public override string ToString()
    {
        return JsonConvert.SerializeObject(_internalSet);
    }
}
