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
public class SFDbSet<TEntity> : ISFDbSet<TEntity> where TEntity : class
{
    private readonly string _tableName;
    private readonly string _schemaName;
    private readonly SFContext _context;
    private readonly ExpressionParser _parser = new();

    /// <summary>
    ///     Initializes a new instance of the <see cref="SFDbSet{TEntity}"/> class.
    /// </summary>
    /// <param name="context">The <see cref="SFContext"/> parameter.</param>
    public SFDbSet(SFContext context)
    {
        _context = context;

        var tableMeta = EntityOperations.GetTableName(typeof(TEntity));
        _tableName = tableMeta.TableName;
        _schemaName = tableMeta.SchemaName;
    }

    /// <inheritdoc />
    public TEntity Add(TEntity entity, bool overwrite = false)
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
    public async Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> expression)
    {
        _parser.Visit(expression);
        var sql = SqlActions<TEntity>.SelectAll(new SqlActionOptions(_parser));

        return await _context.ExecuteAsync<TEntity>(sql);
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
