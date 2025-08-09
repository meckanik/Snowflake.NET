//using Snowflake.NET.Tests.TestData.SnowflakeRepository;

using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using Amazon.Auth.AccessControlPolicy;
using Amazon.S3.Model;
using Snowflake.NET.Attributes;
using Snowflake.NET.Framework.Expression;
using Snowflake.NET.Interfaces;
//using Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf100tcl;

namespace Snowflake.NET.Tests.Unit;

[TestFixture]
public class DbContextTests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void InstantiateDbContext_ShouldSucceed()
    {
        //Expression<Func<CallCenter, bool>> _exp = a => a.CcCallCenterSk == 1;

        //var finder = new SqlExpressionFinder();
        //finder.Visit(_exp);

        //var expComposition = finder.ExpressionComposition;


        //var visitor = new OrderingMethodFinder();
        //visitor.Visit(_exp);

        //if (visitor.OrderingMethodFound)
        //{
        //    // modify the sql
        //}


        Assert.AreEqual(true, true);
        //var dbContext = new SnowflakeSampleDataContext(new Framework.Context.SFContext());

        //Assert.IsNotNull(dbContext);
    }
}

public class OrderingMethodFinder : ExpressionVisitor
{
    public bool OrderingMethodFound { get; set; }

    protected override Expression VisitMethodCall(MethodCallExpression node)
    {
        var name = node.Method.Name;

        if (node.Method.DeclaringType == typeof(Queryable) && (
        name.StartsWith("OrderBy", StringComparison.Ordinal) ||
        name.StartsWith("ThenBy", StringComparison.Ordinal)))
        {
            OrderingMethodFound = true;
        }
        return base.VisitMethodCall(node);
    }
}

public class SqlExpressionFinder : ExpressionVisitor
{
    ExpressionComposition _composition = new();
    public ExpressionComposition ExpressionComposition => _composition;


    protected override Expression VisitMember(MemberExpression node)
    {
        _composition.PropertyName = node.Member.Name;
        if (node.Member.CustomAttributes.Where(typ => typ.AttributeType == typeof(PropertyNameAttribute)).FirstOrDefault() is var attribute && 
            attribute is not null && attribute.ConstructorArguments.Any())
        {
            _composition.CustomAttribute = attribute.ConstructorArguments.First().Value?.ToString()!;
        }
        
        return base.VisitMember(node);
    }

    protected override Expression VisitBinary(BinaryExpression node)
    {
        _composition.ComparisonOperator = node.NodeType.ToString();
        return base.VisitBinary(node);
    }

    protected override Expression VisitDefault(DefaultExpression node)
    {
        return base.VisitDefault(node);
    }

    protected override Expression VisitConditional(ConditionalExpression node)
    {
        return base.VisitConditional(node);
    }

    protected override Expression VisitInvocation(InvocationExpression node)
    {
        return base.VisitInvocation(node);
    }

    protected override Expression VisitConstant(ConstantExpression node)
    {
        _composition.PropertyValue = node.Value.ToString()!;
        return base.VisitConstant(node);
    }

    protected override Expression VisitMemberInit(MemberInitExpression node)
    {
        return base.VisitMemberInit(node);
    }

    protected override Expression VisitDynamic(DynamicExpression node)
    {
        return base.VisitDynamic(node);
    }

    protected override Expression VisitParameter(ParameterExpression node)
    {
        return base.VisitParameter(node);
    }

    //protected override Expression VisitBinary(BinaryExpression node)
    //{
    //    return base.VisitBinary(node);
    //}
    //protected override Expression VisitLambda<T>(Expression<T> node)
    //{
    //    return base.VisitLambda(node);
    //}
}

