using System.Linq.Expressions;

namespace Snowflake.NET.Framework.Interfaces;

internal interface ISFDbSet<TEntity>
{
    /// <summary>
    ///     Adds an object to the table.
    /// </summary>
    /// <param name="entity">The entity type parameter.</param>
    /// <param name="overwrite">Flag for overwriting an existing record.</param>
    /// <returns>The newly created object.</returns>
    Task<TEntity> AddAsync(TEntity entity, bool overwrite = false);

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
    Task<IEnumerable<TEntity>> FindAsync(string id);

    /// <summary>
    ///     Finds an existing object from the passed-in expression.
    /// </summary>
    /// <param name="expression">The search expression parameter.</param>
    /// <returns>The object, if found.</returns>
    Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> expression);

    /// <summary>
    ///     Removes an object matching the passed-in id.
    /// </summary>
    /// <param name="id">The id parameter.</param>
    /// <returns>True, if successful.</returns>
    Task<bool> RemoveAsync(string id);

    /// <summary>
    ///     Removes an object matching the passed-in object.
    /// </summary>
    /// <param name="id">The id parameter.</param>
    /// <returns>True, if successful.</returns>
    Task<bool> RemoveAsync(TEntity entity);

    /// <summary>
    ///     Updates an existing object (transactional).
    /// </summary>
    /// <param name="entity">The updated object.</param>
    /// <returns>The number of records effected.</returns>
    Task<long> UpdateAsync(TEntity entity);

    /// <summary>
    ///     Updates an existing object (transactional).
    /// </summary>
    /// <param name="entity">The unmodified object.</param>
    /// <param name="entity">The updated object.</param>
    /// <returns>The number of records effected.</returns>
    Task<long> UpdateAsync(TEntity entity, TEntity update);

    /// <summary>
    ///     Updates an existing object (transactional).
    /// </summary>
    /// <param name="expression">The search expression parameter.</param>
    /// <param name="update">The updated object.</param>
    /// <returns>The number of records effected.</returns>
    Task<long> Update(Expression<Func<TEntity, bool>> expression, TEntity update);
}
