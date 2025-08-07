namespace Snowflake.NET.Helpers;

/// <summary>
///     Contains helper methods for working with strings.
/// </summary>
public static class TextHelpers
{
    /// <summary>
    ///     Pluralizes a string.
    /// </summary>
    /// <param name="name">The value to pluralize.</param>
    /// <returns>A pluralized string.</returns>
    public static string PluralizeName(string name)
    {
        var result = new string[] { name };
        var chk = name[name.Length - 1].ToString();
        if (string.Equals(chk, "Y", StringComparison.OrdinalIgnoreCase))
        {
            result[0] = $"{new string(result[0].Take(name.Length - 1).ToArray())}ies";
        }
        else if (!string.Equals(chk, "S", StringComparison.OrdinalIgnoreCase))
        {
            result[0] = $"{result[0]}s";
        }
        
        return result[0];
    }

    /// <summary>
    ///     Removes the last instance of CFLR from the passed-in string.
    /// </summary>
    /// <param name="value">The string value to update.</param>
    /// <returns>The updated string value.</returns>
    public static string RemoveTrailingCrLf(string value)
    {
        var tmp = new string[] { value };
        var indx = tmp[0].LastIndexOf('\n');
        tmp[0] = tmp[0].Substring(0, indx);
        indx = tmp[0].LastIndexOf('\r');
        
        return tmp[0].Substring(0, indx);
    }
}
