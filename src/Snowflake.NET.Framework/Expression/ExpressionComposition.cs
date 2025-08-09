namespace Snowflake.NET.Framework.Expression;

/// <summary>
///     Property class for expression elements.
/// </summary>
public class ExpressionComposition
{
    private string _comparisonOperator = string.Empty;

    /// <summary>
    ///     Gets or sets the PropertyName value.
    /// </summary>
    public string PropertyName { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the ComparisonOperator value.
    /// </summary>
    public string ComparisonOperator 
    { 
        get { return _comparisonOperator; }
        set {  _comparisonOperator = ComparisonMapper.Map(value); }
    }

    /// <summary>
    ///     Gets or sets the PropertyValue value.
    /// </summary>
    public string PropertyValue {  get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the CustomAttribute value.
    /// </summary>
    public string CustomAttribute { get; set; } = string.Empty;
}
