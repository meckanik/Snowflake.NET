using Snowflake.NET.Framework.Expression;

namespace Snowflake.NET.Framework.Sql;

/// <summary>
///     Property class for optional sql operation elements.
/// </summary>
public class SqlActionOptions
{
    private readonly IEnumerable<ExpressionComposition>? _where;
    private readonly ExpressionComposition? _rlike;

    /// <summary>
    ///     Initializes a new instance of the <see cref="SqlActionOptions"/> class.
    /// </summary>
    /// <param name="parser">The <see cref="ExpressionParser"/> parameter.</param>
    public SqlActionOptions(ExpressionParser parser)
    {
        if (parser.IsWhere)
        {
            _where = [parser.ExpressionComposition];
        }
        else if (parser.IsRlike)
        {
            _rlike = parser.ExpressionComposition;
        }
    }

    /// <summary>
    ///     Gets the RLike value.
    /// </summary>
    public ExpressionComposition? RLike => _rlike;

    /// <summary>
    ///     Gets the Where value.
    /// </summary>
    public IEnumerable<ExpressionComposition>? Where => _where;
}
