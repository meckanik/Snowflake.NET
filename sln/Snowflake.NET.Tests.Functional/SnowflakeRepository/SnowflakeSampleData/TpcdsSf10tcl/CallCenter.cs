using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf10tcl;

/// <summary>
///		Property class for the CALL_CENTER table.
/// </summary>
[TableName("CALL_CENTER")]
public class CallCenter
{
	/// <summary>
	///	Gets or sets the CC_SUITE_NUMBER value.
	/// </summary>
	[PropertyName("CC_SUITE_NUMBER")]
	public String? CcSuiteNumber  { get; set; }

	/// <summary>
	///	Gets or sets the CC_COMPANY_NAME value.
	/// </summary>
	[PropertyName("CC_COMPANY_NAME")]
	public String? CcCompanyName  { get; set; }

	/// <summary>
	///	Gets or sets the CC_CALL_CENTER_SK value.
	/// </summary>
	[PropertyName("CC_CALL_CENTER_SK")]
	public Int32? CcCallCenterSk  { get; set; }

	/// <summary>
	///	Gets or sets the CC_GMT_OFFSET value.
	/// </summary>
	[PropertyName("CC_GMT_OFFSET")]
	public Int32? CcGmtOffset  { get; set; }

	/// <summary>
	///	Gets or sets the CC_MKT_CLASS value.
	/// </summary>
	[PropertyName("CC_MKT_CLASS")]
	public String? CcMktClass  { get; set; }

	/// <summary>
	///	Gets or sets the CC_ZIP value.
	/// </summary>
	[PropertyName("CC_ZIP")]
	public String? CcZip  { get; set; }

	/// <summary>
	///	Gets or sets the CC_OPEN_DATE_SK value.
	/// </summary>
	[PropertyName("CC_OPEN_DATE_SK")]
	public Int32? CcOpenDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the CC_CALL_CENTER_ID value.
	/// </summary>
	[PropertyName("CC_CALL_CENTER_ID")]
	public String? CcCallCenterId  { get; set; }

	/// <summary>
	///	Gets or sets the CC_COUNTY value.
	/// </summary>
	[PropertyName("CC_COUNTY")]
	public String? CcCounty  { get; set; }

	/// <summary>
	///	Gets or sets the CC_STATE value.
	/// </summary>
	[PropertyName("CC_STATE")]
	public String? CcState  { get; set; }

	/// <summary>
	///	Gets or sets the CC_STREET_TYPE value.
	/// </summary>
	[PropertyName("CC_STREET_TYPE")]
	public String? CcStreetType  { get; set; }

	/// <summary>
	///	Gets or sets the CC_COMPANY value.
	/// </summary>
	[PropertyName("CC_COMPANY")]
	public Int32? CcCompany  { get; set; }

	/// <summary>
	///	Gets or sets the CC_NAME value.
	/// </summary>
	[PropertyName("CC_NAME")]
	public String? CcName  { get; set; }

	/// <summary>
	///	Gets or sets the CC_HOURS value.
	/// </summary>
	[PropertyName("CC_HOURS")]
	public String? CcHours  { get; set; }

	/// <summary>
	///	Gets or sets the CC_REC_END_DATE value.
	/// </summary>
	[PropertyName("CC_REC_END_DATE")]
	public DateTime? CcRecEndDate  { get; set; }

	/// <summary>
	///	Gets or sets the CC_STREET_NAME value.
	/// </summary>
	[PropertyName("CC_STREET_NAME")]
	public String? CcStreetName  { get; set; }

	/// <summary>
	///	Gets or sets the CC_CLASS value.
	/// </summary>
	[PropertyName("CC_CLASS")]
	public String? CcClass  { get; set; }

	/// <summary>
	///	Gets or sets the CC_CITY value.
	/// </summary>
	[PropertyName("CC_CITY")]
	public String? CcCity  { get; set; }

	/// <summary>
	///	Gets or sets the CC_DIVISION_NAME value.
	/// </summary>
	[PropertyName("CC_DIVISION_NAME")]
	public String? CcDivisionName  { get; set; }

	/// <summary>
	///	Gets or sets the CC_MARKET_MANAGER value.
	/// </summary>
	[PropertyName("CC_MARKET_MANAGER")]
	public String? CcMarketManager  { get; set; }

	/// <summary>
	///	Gets or sets the CC_STREET_NUMBER value.
	/// </summary>
	[PropertyName("CC_STREET_NUMBER")]
	public String? CcStreetNumber  { get; set; }

	/// <summary>
	///	Gets or sets the CC_DIVISION value.
	/// </summary>
	[PropertyName("CC_DIVISION")]
	public Int32? CcDivision  { get; set; }

	/// <summary>
	///	Gets or sets the CC_SQ_FT value.
	/// </summary>
	[PropertyName("CC_SQ_FT")]
	public Int32? CcSqFt  { get; set; }

	/// <summary>
	///	Gets or sets the CC_MANAGER value.
	/// </summary>
	[PropertyName("CC_MANAGER")]
	public String? CcManager  { get; set; }

	/// <summary>
	///	Gets or sets the CC_MKT_ID value.
	/// </summary>
	[PropertyName("CC_MKT_ID")]
	public Int32? CcMktId  { get; set; }

	/// <summary>
	///	Gets or sets the CC_CLOSED_DATE_SK value.
	/// </summary>
	[PropertyName("CC_CLOSED_DATE_SK")]
	public Int32? CcClosedDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the CC_REC_START_DATE value.
	/// </summary>
	[PropertyName("CC_REC_START_DATE")]
	public DateTime? CcRecStartDate  { get; set; }

	/// <summary>
	///	Gets or sets the CC_TAX_PERCENTAGE value.
	/// </summary>
	[PropertyName("CC_TAX_PERCENTAGE")]
	public Int32? CcTaxPercentage  { get; set; }

	/// <summary>
	///	Gets or sets the CC_EMPLOYEES value.
	/// </summary>
	[PropertyName("CC_EMPLOYEES")]
	public Int32? CcEmployees  { get; set; }

	/// <summary>
	///	Gets or sets the CC_MKT_DESC value.
	/// </summary>
	[PropertyName("CC_MKT_DESC")]
	public String? CcMktDesc  { get; set; }

	/// <summary>
	///	Gets or sets the CC_COUNTRY value.
	/// </summary>
	[PropertyName("CC_COUNTRY")]
	public String? CcCountry  { get; set; }
}
