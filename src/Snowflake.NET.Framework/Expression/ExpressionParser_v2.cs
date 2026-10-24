using System.Linq.Expressions;
using Snowflake.NET.Attributes;

namespace Snowflake.NET.Framework.Expression;

/// <summary>
///     Uses the visitor pattern to gather the components of a given expression.
/// </summary>
public class ExpressionParser_v2 : ExpressionVisitor
{
    private readonly List<ExpressionComposition> _compositions = [];
    private ExpressionComposition _current = new();

    /// <summary>
    ///     Gets the ExpressionComposition value (first/primary composition).
    /// </summary>
    public ExpressionComposition ExpressionComposition => _compositions.FirstOrDefault() ?? _current;

    /// <summary>
    ///     Gets all parsed compositions (for compound AND/OR expressions).
    /// </summary>
    public IReadOnlyList<ExpressionComposition> Compositions => _compositions;

    /// <summary>
    ///     Gets or sets the IsRlike value.
    /// </summary>
    public bool IsRlike { get; set; }

    /// <summary>
    ///     Gets whether this expression should produce a WHERE clause.
    /// </summary>
    public bool IsWhere => !IsRlike;

    protected override System.Linq.Expressions.Expression VisitMember(MemberExpression node)
    {
        _current.PropertyName = node.Member.Name;

        if (node.Member.CustomAttributes
                .FirstOrDefault(typ => typ.AttributeType == typeof(PropertyNameAttribute)) is var attribute
            && attribute is not null
            && attribute.ConstructorArguments.Any())
        {
            _current.CustomAttribute = attribute.ConstructorArguments.First().Value?.ToString()!;
        }
        else
        {
            // Fall back to the property name itself when no attribute is present.
            _current.CustomAttribute = node.Member.Name;
        }

        return base.VisitMember(node);
    }

    protected override System.Linq.Expressions.Expression VisitBinary(BinaryExpression node)
    {
        switch (node.NodeType)
        {
            // Logical combinators — recurse into both sides independently.
            case ExpressionType.AndAlso:
            case ExpressionType.OrElse:
                _current.LogicalOperator = node.NodeType == ExpressionType.AndAlso ? "AND" : "OR";
                Visit(node.Left);
                CommitCurrent();
                Visit(node.Right);
                CommitCurrent();
                return node;

            // Comparison operators — map to Snowflake SQL equivalents.
            case ExpressionType.Equal:
                _current.ComparisonOperator = "=";
                break;
            case ExpressionType.NotEqual:
                _current.ComparisonOperator = "<>";
                break;
            case ExpressionType.GreaterThan:
                _current.ComparisonOperator = ">";
                break;
            case ExpressionType.GreaterThanOrEqual:
                _current.ComparisonOperator = ">=";
                break;
            case ExpressionType.LessThan:
                _current.ComparisonOperator = "<";
                break;
            case ExpressionType.LessThanOrEqual:
                _current.ComparisonOperator = "<=";
                break;

            default:
                _current.ComparisonOperator = node.NodeType.ToString();
                break;
        }

        return base.VisitBinary(node);
    }

    protected override System.Linq.Expressions.Expression VisitConstant(ConstantExpression node)
    {
        if (node.Value is null)
        {
            _current.IsNullCheck = true;
            _current.PropertyValue = null!;
        }
        else
        {
            _current.PropertyValue = node.Value.ToString()!;
        }

        return base.VisitConstant(node);
    }

    protected override System.Linq.Expressions.Expression VisitUnary(UnaryExpression node)
    {
        if (node.NodeType == ExpressionType.Not)
        {
            _current.IsNegated = true;
        }

        return base.VisitUnary(node);
    }

    protected override System.Linq.Expressions.Expression VisitMethodCall(MethodCallExpression node)
    {
        var name = node.Method.Name;

        if (node.Method.DeclaringType == typeof(Queryable) && (
            name.StartsWith("OrderBy", StringComparison.Ordinal) ||
            name.StartsWith("ThenBy", StringComparison.Ordinal)))
        {
            // Reserved for ordering support.
        }
        else if (node.Method.DeclaringType == typeof(string))
        {
            switch (name)
            {
                case "Equals":
                    if (node.Arguments is not null && node.Arguments.Count >= 1)
                    {
                        IsRlike = true;
                        _current.MethodPropertyValue = ((ConstantExpression)node.Arguments[0]).Value?.ToString()!;
                        _current.MethodPropertyName = node.Object is MemberExpression me ? me.Member.Name : string.Empty;
                        _current.MethodComparisonOperator = "Equal";
                        Visit(node.Object);
                    }
                    return node;

                case "Contains":
                    Visit(node.Object);
                    _current.ComparisonOperator = "LIKE";
                    _current.PropertyValue = $"%{((ConstantExpression)node.Arguments[0]).Value}%";
                    break;

                case "StartsWith":
                    Visit(node.Object);
                    _current.ComparisonOperator = "LIKE";
                    _current.PropertyValue = $"{((ConstantExpression)node.Arguments[0]).Value}%";
                    break;

                case "EndsWith":
                    Visit(node.Object);
                    _current.ComparisonOperator = "LIKE";
                    _current.PropertyValue = $"%{((ConstantExpression)node.Arguments[0]).Value}";
                    break;

                case "IsNullOrEmpty":
                    Visit(node.Arguments[0]);
                    _current.IsNullOrEmptyCheck = true;
                    return node;

                case "Trim":
                    // Wrap the column name in Snowflake's TRIM() function.
                    Visit(node.Object);
                    _current.CustomAttribute = $"TRIM({_current.CustomAttribute})";
                    break;
            }
        }

        return base.VisitMethodCall(node);
    }

    // -------------------------------------------------------------------------
    // Helpers
    // -------------------------------------------------------------------------

    /// <summary>
    ///     Resets the parser state so the same instance can be reused for a fresh expression.
    /// </summary>
    public void Reset()
    {
        _compositions.Clear();
        _current = new ExpressionComposition();
        IsRlike = false;
    }

    private void CommitCurrent()
    {
        if (!string.IsNullOrEmpty(_current.PropertyName) || _current.IsNullCheck || _current.IsNullOrEmptyCheck)
        {
            _compositions.Add(_current);
        }

        _current = new ExpressionComposition();
    }
}