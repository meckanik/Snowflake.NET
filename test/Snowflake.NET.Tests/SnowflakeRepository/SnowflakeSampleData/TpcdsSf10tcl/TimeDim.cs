using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf10tcl;

/// <summary>
///		Property class for the TIME_DIM table.
/// </summary>
[TableName("TPCDS_SF10TCL.TIME_DIM")]
public class TimeDim
{
	/// <summary>
	///	Gets or sets the T_HOUR value.
	/// </summary>
	[PropertyName("T_HOUR")]
	public Int32? THour  { get; set; }

	/// <summary>
	///	Gets or sets the T_AM_PM value.
	/// </summary>
	[PropertyName("T_AM_PM")]
	public String? TAmPm  { get; set; }

	/// <summary>
	///	Gets or sets the T_MINUTE value.
	/// </summary>
	[PropertyName("T_MINUTE")]
	public Int32? TMinute  { get; set; }

	/// <summary>
	///	Gets or sets the T_SUB_SHIFT value.
	/// </summary>
	[PropertyName("T_SUB_SHIFT")]
	public String? TSubShift  { get; set; }

	/// <summary>
	///	Gets or sets the T_TIME_ID value.
	/// </summary>
	[PropertyName("T_TIME_ID")]
	public String? TTimeId  { get; set; }

	/// <summary>
	///	Gets or sets the T_SHIFT value.
	/// </summary>
	[PropertyName("T_SHIFT")]
	public String? TShift  { get; set; }

	/// <summary>
	///	Gets or sets the T_MEAL_TIME value.
	/// </summary>
	[PropertyName("T_MEAL_TIME")]
	public String? TMealTime  { get; set; }

	/// <summary>
	///	Gets or sets the T_SECOND value.
	/// </summary>
	[PropertyName("T_SECOND")]
	public Int32? TSecond  { get; set; }

	/// <summary>
	///	Gets or sets the T_TIME_SK value.
	/// </summary>
	[PropertyName("T_TIME_SK")]
	public Int32? TTimeSk  { get; set; }

	/// <summary>
	///	Gets or sets the T_TIME value.
	/// </summary>
	[PropertyName("T_TIME")]
	public Int32? TTime  { get; set; }
}
