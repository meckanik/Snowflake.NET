namespace Snowflake.NET.Helpers;

/// <summary>
///     Contains methods for mapping Snowflake data types to .NET.
/// </summary>
public static class TypeMapper
{
    /// <summary>
    ///     Maps a Snowflake data type to a .Net type.
    /// </summary>
    /// <param name="dataType">The Snowflake data type value.</param>
    /// <returns>The appropriate .Net type value.</returns>
    public static string Map(string dataType) => dataType.ToUpperInvariant() switch
    {
        "NUMBER" or "NUMERIC" or "INT" or "INTEGER" => typeof(Int32).Name,
        "SMALLINT" or "TINYINT" or "BYTEINT" => typeof(Int16).Name,
        "BIGINT" => typeof(Int64).Name,
        "DECIMAL" => typeof(decimal).Name,
        "FLOAT" or "FLOAT4" or "FLOAT8" => typeof(float).Name,
        "DOUBLE" or "DOUBLE PRECISION" or "REAL" => typeof(double).Name,
        "CHAR" or "CHARACTER" => typeof(char).Name,
        "STRING" or "TEXT" or "VARCHAR" => typeof(string).Name,
        "BINARY" or "VARBINARY" => typeof(string).Name,
        "BOOLEAN" => typeof(bool).Name,
        "DATE" or
        "DATETIME" or
        "TIME" or
        "TIMESTAMP" or
        "TIMESTAMP_LTZ" or
        "TIMESTAMP_NTZ" or
        "TIMESTAMP_TZ" => typeof(DateTime).Name,
        "VARIENT" or "OBJECT" or "ARRAY" => typeof(object).Name,
        _ => typeof(object).Name
    };
}
