using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf10tcl;

/// <summary>
///		Property class for the WEB_PAGE table.
/// </summary>
[TableName("TPCDS_SF10TCL.WEB_PAGE")]
public class WebPage
{
	/// <summary>
	///	Gets or sets the WP_CHAR_COUNT value.
	/// </summary>
	[PropertyName("WP_CHAR_COUNT")]
	public Int32? WpCharCount  { get; set; }

	/// <summary>
	///	Gets or sets the WP_TYPE value.
	/// </summary>
	[PropertyName("WP_TYPE")]
	public String? WpType  { get; set; }

	/// <summary>
	///	Gets or sets the WP_REC_END_DATE value.
	/// </summary>
	[PropertyName("WP_REC_END_DATE")]
	public DateTime? WpRecEndDate  { get; set; }

	/// <summary>
	///	Gets or sets the WP_AUTOGEN_FLAG value.
	/// </summary>
	[PropertyName("WP_AUTOGEN_FLAG")]
	public String? WpAutogenFlag  { get; set; }

	/// <summary>
	///	Gets or sets the WP_CREATION_DATE_SK value.
	/// </summary>
	[PropertyName("WP_CREATION_DATE_SK")]
	public Int32? WpCreationDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the WP_ACCESS_DATE_SK value.
	/// </summary>
	[PropertyName("WP_ACCESS_DATE_SK")]
	public Int32? WpAccessDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the WP_MAX_AD_COUNT value.
	/// </summary>
	[PropertyName("WP_MAX_AD_COUNT")]
	public Int32? WpMaxAdCount  { get; set; }

	/// <summary>
	///	Gets or sets the WP_WEB_PAGE_ID value.
	/// </summary>
	[PropertyName("WP_WEB_PAGE_ID")]
	public String? WpWebPageId  { get; set; }

	/// <summary>
	///	Gets or sets the WP_WEB_PAGE_SK value.
	/// </summary>
	[PropertyName("WP_WEB_PAGE_SK")]
	public Int32? WpWebPageSk  { get; set; }

	/// <summary>
	///	Gets or sets the WP_CUSTOMER_SK value.
	/// </summary>
	[PropertyName("WP_CUSTOMER_SK")]
	public Int32? WpCustomerSk  { get; set; }

	/// <summary>
	///	Gets or sets the WP_LINK_COUNT value.
	/// </summary>
	[PropertyName("WP_LINK_COUNT")]
	public Int32? WpLinkCount  { get; set; }

	/// <summary>
	///	Gets or sets the WP_URL value.
	/// </summary>
	[PropertyName("WP_URL")]
	public String? WpUrl  { get; set; }

	/// <summary>
	///	Gets or sets the WP_IMAGE_COUNT value.
	/// </summary>
	[PropertyName("WP_IMAGE_COUNT")]
	public Int32? WpImageCount  { get; set; }

	/// <summary>
	///	Gets or sets the WP_REC_START_DATE value.
	/// </summary>
	[PropertyName("WP_REC_START_DATE")]
	public DateTime? WpRecStartDate  { get; set; }
}
