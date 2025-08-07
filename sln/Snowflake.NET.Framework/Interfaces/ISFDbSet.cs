using System.Linq.Expressions;

namespace Snowflake.NET.Framework.Interfaces;

internal interface ISFDbSet<TEntity>
{
    /// <summary>
    ///     Adds an object to the table.
    /// </summary>
    /// <param name="entity">The entity type parameter.</param>
    /// <returns>The newly created object.</returns>
    TEntity Add(TEntity entity);

    /// <summary>
    ///     Creates a new instance of an object.
    /// </summary>
    /// <returns>An empty object.</returns>
    TEntity Create();

    /// <summary>
    ///     Finds an existing object from the passed-in identifier.
    /// </summary>
    /// <param name="id">The id parameter.</param>
    /// <returns>The object, if found.</returns>
    IEnumerable<TEntity> Find(string id);

    /// <summary>
    ///     Finds an existing object from the passed-in expression.
    /// </summary>
    /// <param name="expression">The search expression parameter.</param>
    /// <returns>The object, if found.</returns>
    IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression);

    /// <summary>
    ///     Removes an object matching the passed-in id.
    /// </summary>
    /// <param name="id">The id parameter.</param>
    /// <returns>True, if successful.</returns>
    bool Remove(string id);

    /// <summary>
    ///     Removes an object matching the passed-in object.
    /// </summary>
    /// <param name="id">The id parameter.</param>
    /// <returns>True, if successful.</returns>
    bool Remove(TEntity entity);

    /// <summary>
    ///     Updates an existing object (transactional).
    /// </summary>
    /// <param name="entity">The updated object.</param>
    /// <returns>The number of records effected.</returns>
    long Update(TEntity entity);
}
