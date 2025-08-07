using System.Linq.Expressions;
using Snowflake.NET.Framework.Context;
using Snowflake.NET.Framework.Interfaces;

namespace Snowflake.NET.Framework.Entity;

/// <summary>
///     Table entity wrapper that allows basic interaction abilities.
/// </summary>
/// <typeparam name="TEntity">The entity type parameter.</typeparam>
public class SFDbSet<TEntity> : ISFDbSet<TEntity>
{
    private readonly SFContext _context;

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
        throw new NotImplementedException();
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
