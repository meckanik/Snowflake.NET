using System.Linq.Expressions;
using Snowflake.NET.Framework.Context;
using Snowflake.NET.Framework.Expression;
using Snowflake.NET.Framework.Interfaces;
using Snowflake.NET.Framework.Sql;

namespace Snowflake.NET.Framework.Entity;

/// <summary>
///     Table entity wrapper that allows basic interaction abilities.
/// </summary>
/// <typeparam name="TEntity">The entity type parameter.</typeparam>
public class SFDbSet<TEntity> : ISFDbSet<TEntity>
{
    private readonly SFContext _context;
    private readonly ExpressionParser _parser = new();

    /// <summary>
    ///     Initializes a new instance of the <see cref="SFDbSet{TEntity}"/> class.
    /// </summary>
    /// <param name="context">The <see cref="SFContext"/> parameter.</param>
    public SFDbSet(SFContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public TEntity Add(TEntity entity)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public TEntity Create()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public IEnumerable<TEntity> Find(string id)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression)
    {
        _parser.Visit(expression);

        var comp = _parser.ExpressionComposition;
        var tableMeta = EntityOperations.GetTableName(typeof(TEntity));
        var options = new SqlActionOptions
        {
            Where = new List<ExpressionComposition> { comp }
        };

        var sql = SqlActions.SelectAll(tableMeta.TableName, tableMeta.SchemaName, options);

        return _context.Execute<TEntity>(sql);
    }

    /// <inheritdoc />
    public bool Remove(string id)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public bool Remove(TEntity entity)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public long Update(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
