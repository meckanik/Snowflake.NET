using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf100tcl;

/// <summary>
///		Property class for the WEB_SITE table.
/// </summary>
[TableName("WEB_SITE")]
public class WebSite
{
	/// <summary>
	///	Gets or sets the WEB_OPEN_DATE_SK value.
	/// </summary>
	[PropertyName("WEB_OPEN_DATE_SK")]
	public Int32? WebOpenDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_CLOSE_DATE_SK value.
	/// </summary>
	[PropertyName("WEB_CLOSE_DATE_SK")]
	public Int32? WebCloseDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_MKT_DESC value.
	/// </summary>
	[PropertyName("WEB_MKT_DESC")]
	public String? WebMktDesc  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_SITE_SK value.
	/// </summary>
	[PropertyName("WEB_SITE_SK")]
	public Int32? WebSiteSk  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_SUITE_NUMBER value.
	/// </summary>
	[PropertyName("WEB_SUITE_NUMBER")]
	public String? WebSuiteNumber  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_NAME value.
	/// </summary>
	[PropertyName("WEB_NAME")]
	public String? WebName  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_REC_START_DATE value.
	/// </summary>
	[PropertyName("WEB_REC_START_DATE")]
	public DateTime? WebRecStartDate  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_MARKET_MANAGER value.
	/// </summary>
	[PropertyName("WEB_MARKET_MANAGER")]
	public String? WebMarketManager  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_CLASS value.
	/// </summary>
	[PropertyName("WEB_CLASS")]
	public String? WebClass  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_CITY value.
	/// </summary>
	[PropertyName("WEB_CITY")]
	public String? WebCity  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_STREET_NUMBER value.
	/// </summary>
	[PropertyName("WEB_STREET_NUMBER")]
	public String? WebStreetNumber  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_MKT_ID value.
	/// </summary>
	[PropertyName("WEB_MKT_ID")]
	public Int32? WebMktId  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_MKT_CLASS value.
	/// </summary>
	[PropertyName("WEB_MKT_CLASS")]
	public String? WebMktClass  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_MANAGER value.
	/// </summary>
	[PropertyName("WEB_MANAGER")]
	public String? WebManager  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_COMPANY_ID value.
	/// </summary>
	[PropertyName("WEB_COMPANY_ID")]
	public Int32? WebCompanyId  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_STATE value.
	/// </summary>
	[PropertyName("WEB_STATE")]
	public String? WebState  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_COMPANY_NAME value.
	/// </summary>
	[PropertyName("WEB_COMPANY_NAME")]
	public String? WebCompanyName  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_REC_END_DATE value.
	/// </summary>
	[PropertyName("WEB_REC_END_DATE")]
	public DateTime? WebRecEndDate  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_TAX_PERCENTAGE value.
	/// </summary>
	[PropertyName("WEB_TAX_PERCENTAGE")]
	public Int32? WebTaxPercentage  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_GMT_OFFSET value.
	/// </summary>
	[PropertyName("WEB_GMT_OFFSET")]
	public Int32? WebGmtOffset  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_STREET_TYPE value.
	/// </summary>
	[PropertyName("WEB_STREET_TYPE")]
	public String? WebStreetType  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_COUNTY value.
	/// </summary>
	[PropertyName("WEB_COUNTY")]
	public String? WebCounty  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_SITE_ID value.
	/// </summary>
	[PropertyName("WEB_SITE_ID")]
	public String? WebSiteId  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_ZIP value.
	/// </summary>
	[PropertyName("WEB_ZIP")]
	public String? WebZip  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_COUNTRY value.
	/// </summary>
	[PropertyName("WEB_COUNTRY")]
	public String? WebCountry  { get; set; }

	/// <summary>
	///	Gets or sets the WEB_STREET_NAME value.
	/// </summary>
	[PropertyName("WEB_STREET_NAME")]
	public String? WebStreetName  { get; set; }
}
