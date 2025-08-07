using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf100tcl;

/// <summary>
///		Property class for the DATE_DIM table.
/// </summary>
[TableName("DATE_DIM")]
public class DateDim
{
	/// <summary>
	///	Gets or sets the D_CURRENT_QUARTER value.
	/// </summary>
	[PropertyName("D_CURRENT_QUARTER")]
	public String? DCurrentQuarter  { get; set; }

	/// <summary>
	///	Gets or sets the D_HOLIDAY value.
	/// </summary>
	[PropertyName("D_HOLIDAY")]
	public String? DHoliday  { get; set; }

	/// <summary>
	///	Gets or sets the D_MOY value.
	/// </summary>
	[PropertyName("D_MOY")]
	public Int32? DMoy  { get; set; }

	/// <summary>
	///	Gets or sets the D_CURRENT_WEEK value.
	/// </summary>
	[PropertyName("D_CURRENT_WEEK")]
	public String? DCurrentWeek  { get; set; }

	/// <summary>
	///	Gets or sets the D_FOLLOWING_HOLIDAY value.
	/// </summary>
	[PropertyName("D_FOLLOWING_HOLIDAY")]
	public String? DFollowingHoliday  { get; set; }

	/// <summary>
	///	Gets or sets the D_DAY_NAME value.
	/// </summary>
	[PropertyName("D_DAY_NAME")]
	public String? DDayName  { get; set; }

	/// <summary>
	///	Gets or sets the D_YEAR value.
	/// </summary>
	[PropertyName("D_YEAR")]
	public Int32? DYear  { get; set; }

	/// <summary>
	///	Gets or sets the D_LAST_DOM value.
	/// </summary>
	[PropertyName("D_LAST_DOM")]
	public Int32? DLastDom  { get; set; }

	/// <summary>
	///	Gets or sets the D_DOM value.
	/// </summary>
	[PropertyName("D_DOM")]
	public Int32? DDom  { get; set; }

	/// <summary>
	///	Gets or sets the D_QUARTER_NAME value.
	/// </summary>
	[PropertyName("D_QUARTER_NAME")]
	public String? DQuarterName  { get; set; }

	/// <summary>
	///	Gets or sets the D_FIRST_DOM value.
	/// </summary>
	[PropertyName("D_FIRST_DOM")]
	public Int32? DFirstDom  { get; set; }

	/// <summary>
	///	Gets or sets the D_FY_WEEK_SEQ value.
	/// </summary>
	[PropertyName("D_FY_WEEK_SEQ")]
	public Int32? DFyWeekSeq  { get; set; }

	/// <summary>
	///	Gets or sets the D_MONTH_SEQ value.
	/// </summary>
	[PropertyName("D_MONTH_SEQ")]
	public Int32? DMonthSeq  { get; set; }

	/// <summary>
	///	Gets or sets the D_QOY value.
	/// </summary>
	[PropertyName("D_QOY")]
	public Int32? DQoy  { get; set; }

	/// <summary>
	///	Gets or sets the D_DATE_ID value.
	/// </summary>
	[PropertyName("D_DATE_ID")]
	public String? DDateId  { get; set; }

	/// <summary>
	///	Gets or sets the D_SAME_DAY_LY value.
	/// </summary>
	[PropertyName("D_SAME_DAY_LY")]
	public Int32? DSameDayLy  { get; set; }

	/// <summary>
	///	Gets or sets the D_CURRENT_YEAR value.
	/// </summary>
	[PropertyName("D_CURRENT_YEAR")]
	public String? DCurrentYear  { get; set; }

	/// <summary>
	///	Gets or sets the D_SAME_DAY_LQ value.
	/// </summary>
	[PropertyName("D_SAME_DAY_LQ")]
	public Int32? DSameDayLq  { get; set; }

	/// <summary>
	///	Gets or sets the D_CURRENT_DAY value.
	/// </summary>
	[PropertyName("D_CURRENT_DAY")]
	public String? DCurrentDay  { get; set; }

	/// <summary>
	///	Gets or sets the D_CURRENT_MONTH value.
	/// </summary>
	[PropertyName("D_CURRENT_MONTH")]
	public String? DCurrentMonth  { get; set; }

	/// <summary>
	///	Gets or sets the D_DATE_SK value.
	/// </summary>
	[PropertyName("D_DATE_SK")]
	public Int32? DDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the D_DATE value.
	/// </summary>
	[PropertyName("D_DATE")]
	public DateTime? DDate  { get; set; }

	/// <summary>
	///	Gets or sets the D_FY_YEAR value.
	/// </summary>
	[PropertyName("D_FY_YEAR")]
	public Int32? DFyYear  { get; set; }

	/// <summary>
	///	Gets or sets the D_DOW value.
	/// </summary>
	[PropertyName("D_DOW")]
	public Int32? DDow  { get; set; }

	/// <summary>
	///	Gets or sets the D_QUARTER_SEQ value.
	/// </summary>
	[PropertyName("D_QUARTER_SEQ")]
	public Int32? DQuarterSeq  { get; set; }

	/// <summary>
	///	Gets or sets the D_WEEK_SEQ value.
	/// </summary>
	[PropertyName("D_WEEK_SEQ")]
	public Int32? DWeekSeq  { get; set; }

	/// <summary>
	///	Gets or sets the D_FY_QUARTER_SEQ value.
	/// </summary>
	[PropertyName("D_FY_QUARTER_SEQ")]
	public Int32? DFyQuarterSeq  { get; set; }

	/// <summary>
	///	Gets or sets the D_WEEKEND value.
	/// </summary>
	[PropertyName("D_WEEKEND")]
	public String? DWeekend  { get; set; }
}
