namespace Snowflake.NET.Models.DAO;

/// <summary>
///     Property class for scaffolding tables.
/// </summary>
public class TableContainer
{
    /// <summary>
    ///     Gets or sets the DatabaseName value.
    /// </summary>
    public string? DatabaseName { get; set; }

    /// <summary>
    ///     Gets or sets the Schema value.
    /// </summary>
    public string? Schema {  get; set; }

    /// <summary>
    ///     Gets or sets the TableName value.
    /// </summary>
    public string? TableName { get; set; }

    /// <summary>
    ///     Gets or sets the TableType value.
    /// </summary>
    public string? TableType { get; set; }

    /// <summary>
    ///     Gets or sets the Columns value.
    /// </summary>
    public IEnumerable<InformationColumn> Columns { get; set; } = [];
}
