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
public static class SqlActions_v2<T> where T : class
{
    private const string SPC = " ";

    private readonly static string _tableName;

    static SqlActions_v2()
    {
        var tableMeta = EntityOperations.GetTableName(typeof(T));
        var schema = $"{tableMeta.SchemaName}." ?? null;

        _tableName = $"{schema}{tableMeta.TableName}";
    }

    /// <summary>
    ///     Generates a SELECT * statement.
    /// </summary>
    /// <param name="options">Optional sql operations.</param>
    /// <returns>A string representing the current sql statement.</returns>
    public static string SelectAll(SqlActionOptions_v2? options = null)
    {
        return ProcessOptions(
            $"{SqlDictionary.Select}{SPC}{SqlDictionary.All}{SPC}{SqlDictionary.From}{SPC}{_tableName}{SPC}",
            options);
    }

    /// <summary>
    ///     Generates a SELECT statement for specific columns.
    /// </summary>
    /// <param name="properties">The column names to return.</param>
    /// <param name="options">Optional sql operations.</param>
    /// <returns>A string representing the current sql statement.</returns>
    public static string SelectSpecific(
        IEnumerable<string> properties,
        SqlActionOptions_v2? options = null)
    {
        PropertyValidators.ValidateArgument(properties);

        var joinedProps = string.Join(",", properties);

        return ProcessOptions(
            $"{SqlDictionary.Select}{SPC}{joinedProps}{SPC}{SqlDictionary.From}{SPC}{_tableName}{SPC}",
            options);
    }

    /// <summary>
    ///     Generates an INSERT INTO statement.
    /// </summary>
    /// <param name="props">Column-name/value pairs to insert.</param>
    /// <returns>A string representing the current sql statement.</returns>
    public static string Insert(FrozenDictionary<string, object?> props)
    {
        return $"{SqlDictionary.InsertInto}{SPC}{_tableName}{SPC}({string.Join(',', props.Select(d => d.Key))})" +
               $"\t{SqlDictionary.Values}{SPC}({FormatInsertProperties(props.Select(v => v.Value))});";
    }

    /// <summary>
    ///     Generates an UPDATE … SET statement for the supplied column/value pairs,
    ///     scoped to the provided options (typically a primary-key WHERE fragment).
    /// </summary>
    /// <param name="props">Column-name/value pairs to update.</param>
    /// <param name="options">Optional sql operations (used to supply the WHERE clause).</param>
    /// <returns>A string representing the current sql statement.</returns>
    public static string Update(FrozenDictionary<string, object?> props, SqlActionOptions_v2? options = null)
    {
        var setClauses = string.Join($",{SPC}", props.Select(p =>
            $"{p.Key}={FormatScalar(p.Value)}"));

        return ProcessOptions(
            $"{SqlDictionary.Update}{SPC}{_tableName}{SPC}{SqlDictionary.Set}{SPC}{setClauses}{SPC}",
            options);
    }

    /// <summary>
    ///     Generates a DELETE FROM statement scoped to the provided options.
    /// </summary>
    /// <param name="options">Optional sql operations (used to supply the WHERE clause).</param>
    /// <returns>A string representing the current sql statement.</returns>
    public static string Delete(SqlActionOptions_v2? options = null)
    {
        return ProcessOptions(
            $"{SqlDictionary.Delete}{SPC}{SqlDictionary.From}{SPC}{_tableName}{SPC}",
            options);
    }

    /// <summary>
    ///     Processes the SqlActionOptions object into sql.
    /// </summary>
    /// <param name="sql">The sql string parameter.</param>
    /// <param name="options">The <see cref="SqlActionOptions_v2"/> parameter.</param>
    /// <returns>A string representing the current sql statement.</returns>
    public static string ProcessOptions(string sql, SqlActionOptions_v2? options)
    {
        if (options is null)
        {
            return sql.Trim();
        }

        if (options.RawWhere is not null)
        {
            return $"{sql.Trim()}{SPC}{SqlDictionary.Where}{SPC}{options.RawWhere};";
        }

        if (options.Where is not null)
        {
            sql = ProcessWhere(sql, options);
        }

        if (options.RLike is not null)
        {
            sql = ProcessRLike(sql, options);
        }

        return sql;
    }

    // -------------------------------------------------------------------------
    // Private helpers
    // -------------------------------------------------------------------------

    private static string ProcessWhere(string sql, SqlActionOptions_v2? options)
    {
        if (options?.Where is null || !options.Where.Any())
        {
            return sql;
        }

        var whereList = options.Where.ToArray();
        var sb = new StringBuilder($"{sql.Trim()}{SPC}{SqlDictionary.Where}{SPC}");

        for (var indx = 0; indx < whereList.Length; indx++)
        {
            var exp = whereList[indx];

            if (exp.IsNullOrEmptyCheck)
            {
                var nullOrEmpty = $"({exp.CustomAttribute} IS NULL OR {exp.CustomAttribute}='')";
                sb.Append(exp.IsNegated ? $"NOT {nullOrEmpty}" : nullOrEmpty);
            }
            else if (exp.IsNullCheck)
            {
                var nullOp = exp.ComparisonOperator == "<>" ? "IS NOT NULL" : "IS NULL";
                sb.Append($"{exp.CustomAttribute}{SPC}{nullOp}");
            }
            else
            {
                if (exp.PropertyValue is null)
                { throw new InvalidOperationException($"{nameof(exp.PropertyValue)} cannot be null."); }
                else
                {
                    var value = Numeric.IsNumericType(exp.PropertyValue.GetType())
                        ? exp.PropertyValue
                        : $"'{exp.PropertyValue}'";

                    sb.Append($"{exp.CustomAttribute}{exp.ComparisonOperator}{value}");
                }
            }

            if (indx < whereList.Length - 1)
            {
                var logicalOp = !string.IsNullOrEmpty(whereList[indx].LogicalOperator)
                    ? whereList[indx].LogicalOperator
                    : SqlDictionary.And;

                sb.Append($"{SPC}{logicalOp}{SPC}");
            }
        }

        return sb.ToString().Trim();
    }

    private static string ProcessRLike(string sql, SqlActionOptions_v2? options)
    {
        if (options?.RLike is null)
        {
            return sql;
        }

        return $"{sql.Trim()}{SPC}{SqlDictionary.Where}{SPC}" +
               $"{SqlDictionary.Rlike}({options.RLike.CustomAttribute}, '{options.RLike.MethodPropertyValue}', 'i');";
    }

    private static string FormatInsertProperties(IEnumerable<object?> values)
    {
        var sb = new StringBuilder();
        foreach (var value in values)
        {
            sb.Append(FormatScalar(value));
            sb.Append(',');
        }

        return sb.ToString().TrimEnd(',');
    }

    private static string FormatScalar(object? value)
    {
        if (value is null)
        {
            return "NULL";
        }

        return Numeric.IsNumericType(value.GetType())
            ? value.ToString()!
            : $"'{value}'";
    }
}