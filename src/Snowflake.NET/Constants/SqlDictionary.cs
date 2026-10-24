using Newtonsoft.Json;

namespace Snowflake.NET.Constants;

/// <summary>
///     A dictionary of Sql commands.
/// </summary>
public static class SqlDictionary
{
    /// <summary>
    ///     Constant for 'SELECT'.
    /// </summary>
    public const string Select = "SELECT";

    /// <summary>
    ///     Constant for 'FROM'.
    /// </summary>
    public const string From = "FROM";

    /// <summary>
    ///     Constant for 'WHERE'.
    /// </summary>
    public const string Where = "WHERE";

    /// <summary>
    ///     Constant for '*'.
    /// </summary>
    public const string All = "*";

    /// <summary>
    ///     Constant for 'AND'.
    /// </summary>
    public const string And = "AND";

    /// <summary>
    ///     Constant for 'RLIKE'.
    /// </summary>
    public const string Rlike = "RLIKE";

    /// <summary>
    ///     Constant for 'INSERT INTO'.
    /// </summary>
    public const string InsertInto = "INSERT INTO";

    /// <summary>
    ///     Constant for 'VALUES'.
    /// </summary>
    public const string Values = "VALUES";

    /// <summary>
    ///     Constant for 'OR'.
    /// </summary>
    public const string Or = "OR";

    /// <summary>
    ///     Constant for 'NOT'.
    /// </summary>
    public const string Not = "NOT";

    /// <summary>
    ///     Constant for 'IN'.
    /// </summary>
    public const string In = "IN";

    /// <summary>
    ///     Constant for 'IS'.
    /// </summary>
    public const string Is = "IS";

    /// <summary>
    ///     Constant for 'IS NULL'.
    /// </summary>
    public const string IsNull = "IS NULL";

    /// <summary>
    ///     Constant for 'IS NOT NULL'.
    /// </summary>
    public const string IsNotNull = "IS NOT NULL";

    /// <summary>
    ///     Constant for 'LIKE'.
    /// </summary>
    public const string Like = "LIKE";

    /// <summary>
    ///     Constant for 'ILIKE'.
    /// </summary>
    public const string Ilike = "ILIKE";

    /// <summary>
    ///     Constant for 'BETWEEN'.
    /// </summary>
    public const string Between = "BETWEEN";

    /// <summary>
    ///     Constant for 'EXISTS'.
    /// </summary>
    public const string Exists = "EXISTS";

    /// <summary>
    ///     Constant for 'DISTINCT'.
    /// </summary>
    public const string Distinct = "DISTINCT";

    /// <summary>
    ///     Constant for 'AS'.
    /// </summary>
    public const string As = "AS";

    /// <summary>
    ///     Constant for 'ON'.
    /// </summary>
    public const string On = "ON";

    /// <summary>
    ///     Constant for 'JOIN'.
    /// </summary>
    public const string Join = "JOIN";

    /// <summary>
    ///     Constant for 'INNER JOIN'.
    /// </summary>
    public const string InnerJoin = "INNER JOIN";

    /// <summary>
    ///     Constant for 'LEFT JOIN'.
    /// </summary>
    public const string LeftJoin = "LEFT JOIN";

    /// <summary>
    ///     Constant for 'RIGHT JOIN'.
    /// </summary>
    public const string RightJoin = "RIGHT JOIN";

    /// <summary>
    ///     Constant for 'FULL JOIN'.
    /// </summary>
    public const string FullJoin = "FULL JOIN";

    /// <summary>
    ///     Constant for 'LATERAL'.
    /// </summary>
    public const string Lateral = "LATERAL";

    /// <summary>
    ///     Constant for 'GROUP BY'.
    /// </summary>
    public const string GroupBy = "GROUP BY";

    /// <summary>
    ///     Constant for 'HAVING'.
    /// </summary>
    public const string Having = "HAVING";

    /// <summary>
    ///     Constant for 'ORDER BY'.
    /// </summary>
    public const string OrderBy = "ORDER BY";

    /// <summary>
    ///     Constant for 'ASC'.
    /// </summary>
    public const string Asc = "ASC";

    /// <summary>
    ///     Constant for 'DESC'.
    /// </summary>
    public const string Desc = "DESC";

    /// <summary>
    ///     Constant for 'LIMIT'.
    /// </summary>
    public const string Limit = "LIMIT";

    /// <summary>
    ///     Constant for 'OFFSET'.
    /// </summary>
    public const string Offset = "OFFSET";

    /// <summary>
    ///     Constant for 'QUALIFY'.
    /// </summary>
    public const string Qualify = "QUALIFY";

    /// <summary>
    ///     Constant for 'SAMPLE'.
    /// </summary>
    public const string Sample = "SAMPLE";

    /// <summary>
    ///     Constant for 'PIVOT'.
    /// </summary>
    public const string Pivot = "PIVOT";

    /// <summary>
    ///     Constant for 'UNPIVOT'.
    /// </summary>
    public const string Unpivot = "UNPIVOT";

    /// <summary>
    ///     Constant for 'UNION'.
    /// </summary>
    public const string Union = "UNION";

    /// <summary>
    ///     Constant for 'UNION ALL'.
    /// </summary>
    public const string UnionAll = "UNION ALL";

    /// <summary>
    ///     Constant for 'WITH'.
    /// </summary>
    public const string With = "WITH";

    /// <summary>
    ///     Constant for 'OVER'.
    /// </summary>
    public const string Over = "OVER";

    /// <summary>
    ///     Constant for 'PARTITION BY'.
    /// </summary>
    public const string PartitionBy = "PARTITION BY";

    /// <summary>
    ///     Constant for 'CLUSTER BY'.
    /// </summary>
    public const string ClusterBy = "CLUSTER BY";

    /// <summary>
    ///     Constant for 'CASE'.
    /// </summary>
    public const string Case = "CASE";

    /// <summary>
    ///     Constant for 'WHEN'.
    /// </summary>
    public const string When = "WHEN";

    /// <summary>
    ///     Constant for 'THEN'.
    /// </summary>
    public const string Then = "THEN";

    /// <summary>
    ///     Constant for 'ELSE'.
    /// </summary>
    public const string Else = "ELSE";

    /// <summary>
    ///     Constant for 'END'.
    /// </summary>
    public const string End = "END";

    /// <summary>
    ///     Constant for 'UPDATE'.
    /// </summary>
    public const string Update = "UPDATE";

    /// <summary>
    ///     Constant for 'SET'.
    /// </summary>
    public const string Set = "SET";

    /// <summary>
    ///     Constant for 'DELETE'.
    /// </summary>
    public const string Delete = "DELETE";

    /// <summary>
    ///     Constant for 'DELETE FROM'.
    /// </summary>
    public const string DeleteFrom = "DELETE FROM";

    /// <summary>
    ///     Constant for 'MERGE'.
    /// </summary>
    public const string Merge = "MERGE";

    /// <summary>
    ///     Constant for 'USING'.
    /// </summary>
    public const string Using = "USING";

    /// <summary>
    ///     Constant for 'INTO'.
    /// </summary>
    public const string Into = "INTO";

    /// <summary>
    ///     Constant for 'MATCHED'.
    /// </summary>
    public const string Matched = "MATCHED";

    /// <summary>
    ///     Constant for 'CREATE TABLE'.
    /// </summary>
    public const string CreateTable = "CREATE TABLE";

    /// <summary>
    ///     Constant for 'CREATE OR REPLACE'.
    /// </summary>
    public const string CreateOrReplace = "CREATE OR REPLACE";

    /// <summary>
    ///     Constant for 'CREATE TEMPORARY TABLE'.
    /// </summary>
    public const string CreateTemporaryTable = "CREATE TEMPORARY TABLE";

    /// <summary>
    ///     Constant for 'DROP TABLE'.
    /// </summary>
    public const string DropTable = "DROP TABLE";

    /// <summary>
    ///     Constant for 'ALTER TABLE'.
    /// </summary>
    public const string AlterTable = "ALTER TABLE";

    /// <summary>
    ///     Constant for 'TRUNCATE TABLE'.
    /// </summary>
    public const string TruncateTable = "TRUNCATE TABLE";

    /// <summary>
    ///     Constant for 'COPY INTO'.
    /// </summary>
    public const string CopyInto = "COPY INTO";

    /// <summary>
    ///     Constant for 'FILE_FORMAT'.
    /// </summary>
    public const string FileFormat = "FILE_FORMAT";

    /// <summary>
    ///     Constant for 'STAGE'.
    /// </summary>
    public const string Stage = "STAGE";

    /// <summary>
    ///     Constant for 'PUT'.
    /// </summary>
    public const string Put = "PUT";

    /// <summary>
    ///     Constant for 'GET'.
    /// </summary>
    public const string Get = "GET";

    /// <summary>
    ///     Constant for 'LIST'.
    /// </summary>
    public const string List = "LIST";

    /// <summary>
    ///     Constant for 'REMOVE'.
    /// </summary>
    public const string Remove = "REMOVE";

    /// <summary>
    ///     Constant for 'WAREHOUSE'.
    /// </summary>
    public const string Warehouse = "WAREHOUSE";

    /// <summary>
    ///     Constant for 'DATABASE'.
    /// </summary>
    public const string Database = "DATABASE";

    /// <summary>
    ///     Constant for 'SCHEMA'.
    /// </summary>
    public const string Schema = "SCHEMA";

    /// <summary>
    ///     Constant for 'USE'.
    /// </summary>
    public const string Use = "USE";

    /// <summary>
    ///     Constant for 'SHOW'.
    /// </summary>
    public const string Show = "SHOW";

    /// <summary>
    ///     Constant for 'DESCRIBE'.
    /// </summary>
    public const string Describe = "DESCRIBE";

    /// <summary>
    ///     Constant for 'GRANT'.
    /// </summary>
    public const string Grant = "GRANT";

    /// <summary>
    ///     Constant for 'REVOKE'.
    /// </summary>
    public const string Revoke = "REVOKE";

    /// <summary>
    ///     Constant for 'CALL'.
    /// </summary>
    public const string Call = "CALL";

    /// <summary>
    ///     Constant for 'EXECUTE IMMEDIATE'.
    /// </summary>
    public const string ExecuteImmediate = "EXECUTE IMMEDIATE";

    /// <summary>
    ///     Constant for 'BEGIN'.
    /// </summary>
    public const string Begin = "BEGIN";

    /// <summary>
    ///     Constant for 'COMMIT'.
    /// </summary>
    public const string Commit = "COMMIT";

    /// <summary>
    ///     Constant for 'ROLLBACK'.
    /// </summary>
    public const string Rollback = "ROLLBACK";

    /// <summary>
    ///     Constant for 'TRANSACTION'.
    /// </summary>
    public const string Transaction = "TRANSACTION";

    /// <summary>
    ///     Constant for 'COUNT'.
    /// </summary>
    public const string Count = "COUNT";

    /// <summary>
    ///     Constant for 'SUM'.
    /// </summary>
    public const string Sum = "SUM";

    /// <summary>
    ///     Constant for 'AVG'.
    /// </summary>
    public const string Avg = "AVG";

    /// <summary>
    ///     Constant for 'MIN'.
    /// </summary>
    public const string Min = "MIN";

    /// <summary>
    ///     Constant for 'MAX'.
    /// </summary>
    public const string Max = "MAX";

    /// <summary>
    ///     Constant for 'COALESCE'.
    /// </summary>
    public const string Coalesce = "COALESCE";

    /// <summary>
    ///     Constant for 'NULLIF'.
    /// </summary>
    public const string NullIf = "NULLIF";

    /// <summary>
    ///     Constant for 'IFF'.
    /// </summary>
    public const string Iff = "IFF";

    /// <summary>
    ///     Constant for 'CAST'.
    /// </summary>
    public const string Cast = "CAST";

    /// <summary>
    ///     Constant for 'TRY_CAST'.
    /// </summary>
    public const string TryCast = "TRY_CAST";

    /// <summary>
    ///     Constant for 'OBJECT_CONSTRUCT'.
    /// </summary>
    public const string ObjectConstruct = "OBJECT_CONSTRUCT";

    /// <summary>
    ///     Constant for 'ARRAY_CONSTRUCT'.
    /// </summary>
    public const string ArrayConstruct = "ARRAY_CONSTRUCT";

    /// <summary>
    ///     Constant for 'TO_VARIANT'.
    /// </summary>
    public const string ToVariant = "TO_VARIANT";

    /// <summary>
    ///     Constant for 'FLATTEN'.
    /// </summary>
    public const string Flatten = "FLATTEN";

    /// <summary>
    ///     Constant for 'TO_ARRAY'.
    /// </summary>
    public const string ToArray = "TO_ARRAY";

    /// <summary>
    ///     Constant for 'TO_OBJECT'.
    /// </summary>
    public const string ToObject = "TO_OBJECT";

    /// <summary>
    ///     Constant for 'ARRAY_AGG'.
    /// </summary>
    public const string ArrayAgg = "ARRAY_AGG";

    /// <summary>
    ///     Constant for 'LISTAGG'.
    /// </summary>
    public const string ListAgg = "LISTAGG";

    /// <summary>
    ///     Constant for 'ROW_NUMBER'.
    /// </summary>
    public const string RowNumber = "ROW_NUMBER";

    /// <summary>
    ///     Constant for 'RANK'.
    /// </summary>
    public const string Rank = "RANK";

    /// <summary>
    ///     Constant for 'DENSE_RANK'.
    /// </summary>
    public const string DenseRank = "DENSE_RANK";

    /// <summary>
    ///     Constant for 'LAG'.
    /// </summary>
    public const string Lag = "LAG";

    /// <summary>
    ///     Constant for 'LEAD'.
    /// </summary>
    public const string Lead = "LEAD";

    /// <summary>
    ///     Returns a sql 'PARSE_JSON' statement with the passed-in
    ///     object deserialized into a Json string.
    /// </summary>
    /// <param name="value">The value to deserialize.</param>
    /// <returns>A string representing a sql method.</returns>
    public static string ParseJson(object value)
    {
        return $"PARSE_JSON({JsonConvert.SerializeObject(value)})";
    }
}