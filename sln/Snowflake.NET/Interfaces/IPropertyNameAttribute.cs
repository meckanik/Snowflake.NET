namespace Snowflake.NET.Interfaces;

/// <summary>
///     Allows the .NET-unfriendly database property name to be
///     retrieved by the Framework classes.
/// </summary>
public interface IPropertyNameAttribute
{
    /// <summary>
    ///     Gets the PropertyName value.
    /// </summary>
    string PropertyName { get; }
}
