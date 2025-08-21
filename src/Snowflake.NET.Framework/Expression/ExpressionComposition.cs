namespace Snowflake.NET.Framework.Expression;

/// <summary>
///     Property class for expression elements.
/// </summary>
public class ExpressionComposition
{
    private string _comparisonOperator = string.Empty;
    private string _methodComparisonOperator = string.Empty;

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

    /// <summary>
    ///     Gets or sets the MethodPropertyName value.
    /// </summary>
    public string MethodPropertyName { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the MethodPropertyValue value.
    /// </summary>
    public string MethodPropertyValue {  get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the MethodComparisonOperator value.
    /// </summary>
    public string MethodComparisonOperator
    {
        get { return _methodComparisonOperator; }
        set { _methodComparisonOperator = ComparisonMapper.Map(value); }
    }
}
