using System.Collections.Frozen;
using System.Text;
using Snowflake.NET.Constants;
using Snowflake.NET.Framework.Entity;
using Snowflake.NET.Helpers;
using Snowflake.NET.Validation;

namespace Snowflake.NET.Framework.Sql;

/// <summary>
///     Contains methods for generating common sql commands.
/// </summary>
public static class SqlActions<T> where T : class
{
    private const string SPC = " ";

    private readonly static string _tableName;

    static SqlActions()
    {
        var tableMeta = EntityOperations.GetTableName(typeof(T));
        var schema = $"{tableMeta.SchemaName}." ?? null;

        _tableName = $"{schema}{tableMeta.TableName}";
    }

    /// <summary>
    ///     Generates a select statement.
    /// </summary>
    /// <param name="options">Optional sql operations.</param>
    /// <returns>A string representing the current sql statement.</returns>
    public static string SelectAll(SqlActionOptions? options = null)
    {
        return ProcessOptions($"{SqlDictionary.Select}{SPC}{SqlDictionary.All}{SPC}{SqlDictionary.From}{SPC}{_tableName}{SPC}", options);
    }

    /// <summary>
    ///     Generates a select statement.
    /// </summary>
    /// <param name="properties">The properties to return.</param>
    /// <param name="options">Optional sql operations.</param>
    /// <returns>A string representing the current sql statement.</returns>
    public static string SelectSpecific(
        IEnumerable<string> properties, 
        SqlActionOptions? options = null) 
    {
        PropertyValidators.ValidateArgument(properties);

        var joinedProps = string.Join(",", properties);

        return $"{SqlDictionary.Select}{SPC}{joinedProps}{SPC}{SqlDictionary.From}{_tableName}";
    }

    public static string Insert(FrozenDictionary<string, object?> props)
    {
        return $"{SqlDictionary.InsertInto}{SPC}{_tableName}{SPC}({string.Join(',', props.Select(d => d.Key))}) " +
            $"\t{SqlDictionary.Values}{SPC}({FormatInsertProperties(props.Select(v => v.Value))});";
    }

    /// <summary>
    ///     Processes the SqlActionOptions object into sql.
    /// </summary>
    /// <param name="sql">The sql string parameter.</param>
    /// <param name="options">The <see cref="SqlActionOptions"/> parameter.</param>
    /// <returns>A string representing the current sql statement.</returns>
    public static string ProcessOptions(string sql, SqlActionOptions? options)
    {
        var result = new string[1] { sql };
        if (options is not null)
        {
            if (options.Where is not null)
            {
                result[0] = ProcessWhere(result[0], options);
            }
            if (options.RLike is not null)
            {
                result[0] = ProcessRLike(result[0], options);
            }
        }

        return result[0];
    }

    private static string ProcessWhere(string sql, SqlActionOptions? options)
    {
        var result = string.Empty;
        if (options is not null && options.Where is not null && options.Where.Any())
        {
            var whereList = options.Where.ToArray();
            var count = options.Where.Count();
            var sb = new StringBuilder($"{sql.Trim()}{SPC}{SqlDictionary.Where}{SPC}");

            for (var indx = 0; indx < count; indx++)
            {
                var exp = whereList[indx];
                sb.Append($"{exp.CustomAttribute}{exp.ComparisonOperator}'{exp.PropertyValue}' ");

                var append = indx == (count - 1) ? SPC : $",{SPC}{SqlDictionary.And}{SPC}";
                sb.Append(append);
            }

            result = sb.ToString();
        }

        return result.Trim();
    }

    private static string ProcessRLike(string sql, SqlActionOptions? options)
    {
        var result = new string[1] { sql }; 
        if (options is not null && options.RLike is not null)
        {
            result[0] = $"{sql.Trim()}{SPC}{SqlDictionary.Where}{SPC}{SqlDictionary.Rlike}({options.RLike.CustomAttribute}, '{options.RLike.MethodPropertyValue}', 'i');";
        }

        return result[0];
    }

    private static string FormatInsertProperties(IEnumerable<object?> values)
    {
        var sb = new StringBuilder();
        foreach (var value in values)
        {
            sb.Append(Numeric.IsNumericType(value?.GetType()!) ? value?.ToString() : $"'{value?.ToString()}'");
            sb.Append(',');
        }

        return sb.ToString().TrimEnd(',');
    }
}
