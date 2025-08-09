using Snowflake.NET.Interfaces;

namespace Snowflake.NET.Attributes;

/// <summary>
///     Identifies a primary key property.
/// </summary>
public class PrimaryKeyAttribute : Attribute, IPrimaryKeyAttribute
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="PrimaryKeyAttribute"/> class.
    /// </summary>
    public PrimaryKeyAttribute() { }
}
