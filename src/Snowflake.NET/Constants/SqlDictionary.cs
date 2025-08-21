using Newtonsoft.Json;

namespace Snowflake.NET.Constants;

/// <summary>
///     A dictionary of Sql commands.
/// </summary>
public static class SqlDictionary
{
    /// <summary>
    ///     Constant for 'SELECT'.
    /// </summary>
    public const string Select = "SELECT";

    /// <summary>
    ///     Constant for 'FROM'.
    /// </summary>
    public const string From = "FROM";

    /// <summary>
    ///     Constant for 'WHERE'.
    /// </summary>
    public const string Where = "WHERE";

    /// <summary>
    ///     Constant for '*'.
    /// </summary>
    public const string All = "*";

    /// <summary>
    ///     Constant for 'AND'.
    /// </summary>
    public const string And = "AND";

    /// <summary>
    ///     Constant for 'RLIKE'.
    /// </summary>
    public const string Rlike = "RLIKE";

    /// <summary>
    ///     Constant for 'INSERT INTO'.
    /// </summary>
    public const string InsertInto = "INSERT INTO";

    /// <summary>
    ///     Constant for 'VALUES'.
    /// </summary>
    public const string Values = "VALUES";

    /// <summary>
    ///     Returns a sql 'PARSE_JSON' statement with the passed-in
    ///     object deserialized into a Json string.
    /// </summary>
    /// <param name="value">The value to deserialize.</param>
    /// <returns>A string representing a sql method.</returns>
    public static string ParseJson(object value)
    {
        return $"PARSE_JSON({JsonConvert.SerializeObject(value)})";
    }
}
