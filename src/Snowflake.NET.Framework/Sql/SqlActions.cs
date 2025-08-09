using System.Text;
using Snowflake.NET.Validation;

namespace Snowflake.NET.Framework.Sql;

/// <summary>
///     Contains methods for generating commong sql commands.
/// </summary>
public static class SqlActions
{
    private const string SELECT = "SELECT";
    private const string FROM = "FROM";
    private const string WHERE = "WHERE";
    private const string ALL = "*";
    private const string AND = "AND";
    private const string SPC = " ";

    /// <summary>
    ///     Generates a select statement.
    /// </summary>
    /// <param name="tableName">The name of the table to query.</param>
    /// <param name="schemaName">The table schema value.</param>
    /// <param name="options">Optional sql operations.</param>
    /// <returns>A textual sql statement.</returns>
    public static string SelectAll(string tableName, string? schemaName = null, SqlActionOptions? options = null)
    {
        PropertyValidators.ValidateArgument(tableName);

        var schema = $"{schemaName}." ?? null;
        var where = ProcessWhere(options);

        return $"{SELECT}{SPC}{ALL}{SPC}{FROM}{SPC}{schema}{tableName}{SPC}{where}";
    }

    /// <summary>
    ///     Generates a select statement.
    /// </summary>
    /// <param name="tableName">The name of the table to query.</param>
    /// <param name="properties">The properties to return.</param>
    /// <param name="schemaName">The table schema value.</param>
    /// <param name="options">Optional sql operations.</param>
    /// <returns></returns>
    public static string SelectSpecific(string tableName, IEnumerable<string> properties, string? schemaName = null, SqlActionOptions? options = null) 
    {
        PropertyValidators.ValidateArgument(tableName);
        PropertyValidators.ValidateArgument(properties);

        var schema = schemaName ?? $"{schemaName}.";
        var joinedProps = string.Join(",", properties);

        return $"{SELECT}{SPC}{joinedProps}{SPC}{FROM}{schema}{tableName}";
    }

    private static string ProcessWhere(SqlActionOptions? options)
    {
        var result = string.Empty;
        if (options is not null && options.Where is not null && options.Where.Any())
        {
            var whereList = options.Where.ToArray();
            var count = options.Where.Count();
            var sb = new StringBuilder($"{WHERE}{SPC}");

            for (var indx = 0; indx < count; indx++)
            {
                var exp = whereList[indx];
                sb.Append($"{exp.CustomAttribute}{exp.ComparisonOperator}'{exp.PropertyValue}' ");

                var append = indx == (count - 1) ? SPC : $",{SPC}{AND}{SPC}";
                sb.Append(append);
            }

            result = sb.ToString();
        }

        return result;
    }
}
