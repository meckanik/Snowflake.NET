using Snowflake.NET.Framework.Expression;

namespace Snowflake.NET.Framework.Sql;

/// <summary>
///     Property class for optional sql operation elements.
/// </summary>
public class SqlActionOptions
{
    /// <summary>
    ///     Gets or sets the Top value.
    /// </summary>
    public long? Top { get; set; }

    /// <summary>
    ///     Gets or sets the Distinct value.
    /// </summary>
    public bool Distinct { get; set; }

    /// <summary>
    ///     Gets or sets the Transactional value.
    /// </summary>
    public bool Transactional { get; set; }

    /// <summary>
    ///     Gets or sets the Where value.
    /// </summary>
    public IEnumerable<ExpressionComposition>? Where { get; set; }
}
