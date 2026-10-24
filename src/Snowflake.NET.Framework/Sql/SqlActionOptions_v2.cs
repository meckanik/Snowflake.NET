using Snowflake.NET.Framework.Expression;

namespace Snowflake.NET.Framework.Sql;

/// <summary>
///     Property class for optional sql operation elements.
/// </summary>
public class SqlActionOptions_v2
{
    private readonly IEnumerable<ExpressionComposition>? _where;
    private readonly ExpressionComposition? _rlike;
    private readonly string? _rawWhere;

    /// <summary>
    ///     Initializes a new instance of the <see cref="SqlActionOptions_v2"/> class from a parsed expression.
    /// </summary>
    /// <param name="parser">The <see cref="ExpressionParser"/> parameter.</param>
    public SqlActionOptions_v2(ExpressionParser_v2 parser)
    {
        if (parser.IsRlike)
        {
            _rlike = parser.ExpressionComposition;
        }
        else if (parser.IsWhere)
        {
            // Use multi-composition list when available (compound AND/OR expressions),
            // falling back to the single primary composition for simple predicates.
            _where = parser.Compositions.Any()
                ? parser.Compositions
                : [parser.ExpressionComposition];
        }
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="SqlActionOptions_v1"/> class from a raw WHERE fragment.
    ///     Used internally for primary-key based Delete and Update operations.
    /// </summary>
    /// <param name="rawWhere">A pre-formatted WHERE clause fragment, e.g. <c>MY_COL='value'</c>.</param>
    internal SqlActionOptions_v2(string rawWhere)
    {
        _rawWhere = rawWhere;
    }

    /// <summary>
    ///     Gets the RLike composition.
    /// </summary>
    public ExpressionComposition? RLike => _rlike;

    /// <summary>
    ///     Gets the Where compositions.
    /// </summary>
    public IEnumerable<ExpressionComposition>? Where => _where;

    /// <summary>
    ///     Gets a raw, pre-formatted WHERE clause fragment. Takes precedence over <see cref="Where"/>.
    /// </summary>
    public string? RawWhere => _rawWhere;
}