using System.Linq.Expressions;
using Snowflake.NET.Attributes;

namespace Snowflake.NET.Framework.Expression;

/// <summary>
///     Uses the visitor pattern to gather the components of a given expression.
/// </summary>
public class ExpressionParser : ExpressionVisitor
{
    ExpressionComposition _composition = new();

    /// <summary>
    ///     Gets the ExpressionComposition value.
    /// </summary>
    public ExpressionComposition ExpressionComposition => _composition;

    protected override System.Linq.Expressions.Expression VisitMember(MemberExpression node)
    {
        _composition.PropertyName = node.Member.Name;
        if (node.Member.CustomAttributes.Where(typ => typ.AttributeType == typeof(PropertyNameAttribute)).FirstOrDefault() is var attribute &&
            attribute is not null && attribute.ConstructorArguments.Any())
        {
            _composition.CustomAttribute = attribute.ConstructorArguments.First().Value?.ToString()!;
        }

        return base.VisitMember(node);
    }

    protected override System.Linq.Expressions.Expression VisitBinary(BinaryExpression node)
    {
        _composition.ComparisonOperator = node.NodeType.ToString();
        return base.VisitBinary(node);
    }

    protected override System.Linq.Expressions.Expression VisitConstant(ConstantExpression node)
    {
        _composition.PropertyValue = node.Value?.ToString()!;
        return base.VisitConstant(node);
    }

    // for future use
    protected override System.Linq.Expressions.Expression VisitMethodCall(MethodCallExpression node)
    {
        var name = node.Method.Name;

        if (node.Method.DeclaringType == typeof(Queryable) && (
        name.StartsWith("OrderBy", StringComparison.Ordinal) ||
        name.StartsWith("ThenBy", StringComparison.Ordinal)))
        {
            //OrderingMethodFound = true;
        }
        return base.VisitMethodCall(node);
    }
}

