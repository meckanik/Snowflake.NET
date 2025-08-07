namespace Snowflake.NET.Interfaces;

/// <summary>
///     Allows the .NET-unfriendly database table name to be
///     retrieved by the Framework classes.
/// </summary>
public interface ITableNameAttribute
{
    /// <summary>
    ///     Gets the TableName value.
    /// </summary>
    string TableName { get; }
}
