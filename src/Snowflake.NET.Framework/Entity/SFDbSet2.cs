//using System.Collections.Frozen;
//using System.Linq.Expressions;
//using System.Reflection;
//using Snowflake.NET.Attributes;
//using Snowflake.NET.Framework.Context;
//using Snowflake.NET.Framework.Expression;
//using Snowflake.NET.Framework.Interfaces;
//using Snowflake.NET.Framework.Sql;
//using Snowflake.NET.Helpers;

//namespace Snowflake.NET.Framework.Entity;

///// <summary>
/////     Table entity wrapper that allows basic interaction abilities.
///// </summary>
///// <typeparam name="TEntity">The entity type parameter.</typeparam>
//public class SFDbSet2<TEntity> : ISFDbSet<TEntity> where TEntity : class
//{
//    private readonly string _tableName;
//    private readonly string _schemaName;
//    private readonly SFContext _context;
//    private readonly ExpressionParser _parser = new();

//    /// <summary>
//    ///     Initializes a new instance of the <see cref="SFDbSet{TEntity}"/> class.
//    /// </summary>
//    /// <param name="context">The <see cref="SFContext"/> parameter.</param>
//    public SFDbSet2(SFContext context)
//    {
//        _context = context;

//        var tableMeta = EntityOperations.GetTableName(typeof(TEntity));
//        _tableName = tableMeta.TableName;
//        _schemaName = tableMeta.SchemaName;
//    }

//    /// <inheritdoc />
//    public async Task<TEntity> Add(TEntity entity, bool overwrite = false)
//    {
//        var props = BuildColumnMap(entity);
//        var sql = SqlActions_v1<TEntity>.Insert(props);

//        await _context.ExecuteAsync<TEntity>(sql);

//        return entity;
//    }

//    /// <inheritdoc />
//    public TEntity Create()
//    {
//        return Activator.CreateInstance<TEntity>();
//    }

//    /// <inheritdoc />
//    public async Task<IEnumerable<TEntity>> Find(string id)
//    {
//        var pkColumn = GetPrimaryKeyColumn();
//        var options = new SqlActionOptions_v1($"{pkColumn}='{id}'");
//        var sql = SqlActions_v1<TEntity>.SelectAll(options);

//        return await _context.ExecuteAsync<TEntity>(sql);
//    }

//    /// <inheritdoc />
//    public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> expression)
//    {
//        _parser.Reset();
//        _parser.Visit(expression);
//        var sql = SqlActions_v1<TEntity>.SelectAll(new SqlActionOptions_v1(_parser));

//        return await _context.ExecuteAsync<TEntity>(sql);
//    }

//    /// <inheritdoc />
//    public async Task<bool> Remove(string id)
//    {
//        var pkColumn = GetPrimaryKeyColumn();
//        var options = new SqlActionOptions_v1($"{pkColumn}='{id}'");
//        var sql = SqlActions_v1<TEntity>.Delete(options);

//        await _context.ExecuteAsync<TEntity>(sql);

//        return true;
//    }

//    /// <inheritdoc />
//    public async Task<bool> Remove(TEntity entity)
//    {
//        var (pkColumn, pkValue) = GetPrimaryKeyValue(entity);
//        var options = new SqlActionOptions_v1($"{pkColumn}='{pkValue}'");
//        var sql = SqlActions_v1<TEntity>.Delete(options);

//        await _context.ExecuteAsync<TEntity>(sql);

//        return true;
//    }

//    /// <inheritdoc />
//    public async Task<long> Update(TEntity entity)
//    {
//        var (pkColumn, pkValue) = GetPrimaryKeyValue(entity);

//        // Exclude the PK column from the SET clause — it is only used in the WHERE.
//        var props = BuildColumnMap(entity, excludePrimaryKey: true);
//        var options = new SqlActionOptions_v1($"{pkColumn}='{pkValue}'");
//        var sql = SqlActions_v1<TEntity>.Update(props, options);

//        await _context.ExecuteAsync<TEntity>(sql);

//        return 1L;
//    }

//    // -------------------------------------------------------------------------
//    // Private helpers
//    // -------------------------------------------------------------------------

//    /// <summary>
//    ///     Builds a frozen dictionary of column-name/value pairs from the entity's properties,
//    ///     using <see cref="PropertyNameAttribute"/> where present to resolve the column name.
//    /// </summary>
//    private static FrozenDictionary<string, object?> BuildColumnMap(
//        TEntity entity,
//        bool excludePrimaryKey = false)
//    {
//        var dict = new Dictionary<string, object?>();

//        foreach (var prop in typeof(TEntity).GetProperties(BindingFlags.Public | BindingFlags.Instance))
//        {
//            if (excludePrimaryKey && prop.GetCustomAttribute<PrimaryKeyAttribute>() is not null)
//            {
//                continue;
//            }

//            var columnName = prop.GetCustomAttribute<PropertyNameAttribute>()?.Name
//                             ?? prop.Name;

//            dict[columnName] = prop.GetValue(entity);
//        }

//        return dict.ToFrozenDictionary();
//    }

//    /// <summary>
//    ///     Returns the column name of the property decorated with <see cref="PrimaryKeyAttribute"/>.
//    ///     Falls back to the first property named "Id" (case-insensitive) if no attribute is found.
//    /// </summary>
//    private static string GetPrimaryKeyColumn()
//    {
//        var pkProp = typeof(TEntity)
//            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
//            .FirstOrDefault(p => p.GetCustomAttribute<PrimaryKeyAttribute>() is not null)
//            ?? typeof(TEntity)
//               .GetProperties(BindingFlags.Public | BindingFlags.Instance)
//               .FirstOrDefault(p => p.Name.Equals("Id", StringComparison.OrdinalIgnoreCase))
//            ?? throw new InvalidOperationException(
//                $"No primary key property found on {typeof(TEntity).Name}. " +
//                $"Decorate the key property with [PrimaryKey].");

//        return pkProp.GetCustomAttribute<PropertyNameAttribute>()?.Name ?? pkProp.Name;
//    }

//    /// <summary>
//    ///     Returns the column name and current value of the primary key on a given entity instance.
//    /// </summary>
//    private static (string column, object? value) GetPrimaryKeyValue(TEntity entity)
//    {
//        var pkProp = typeof(TEntity)
//            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
//            .FirstOrDefault(p => p.GetCustomAttribute<PrimaryKeyAttribute>() is not null)
//            ?? typeof(TEntity)
//               .GetProperties(BindingFlags.Public | BindingFlags.Instance)
//               .FirstOrDefault(p => p.Name.Equals("Id", StringComparison.OrdinalIgnoreCase))
//            ?? throw new InvalidOperationException(
//                $"No primary key property found on {typeof(TEntity).Name}. " +
//                $"Decorate the key property with [PrimaryKey].");

//        var column = pkProp.GetCustomAttribute<PropertyNameAttribute>()?.Name ?? pkProp.Name;
//        var value = pkProp.GetValue(entity);

//        return (column, value);
//    }
//}