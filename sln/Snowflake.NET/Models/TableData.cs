using Snowflake.NET.Models.DAO;

namespace Snowflake.NET.Models;

/// <summary>
///     Property class for table data.
/// </summary>
public class TableData
{
    /// <summary>
    ///     Gets or sets the Schema value.
    /// </summary>
    public string Schema { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the Data value.
    /// </summary>
    public IEnumerable<TableContainer> Data { get; set; } = [];
}
