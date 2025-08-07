using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf10tcl;

/// <summary>
///		Property class for the STORE table.
/// </summary>
[TableName("STORE")]
public class Store
{
	/// <summary>
	///	Gets or sets the S_CITY value.
	/// </summary>
	[PropertyName("S_CITY")]
	public String? SCity  { get; set; }

	/// <summary>
	///	Gets or sets the S_STREET_NUMBER value.
	/// </summary>
	[PropertyName("S_STREET_NUMBER")]
	public String? SStreetNumber  { get; set; }

	/// <summary>
	///	Gets or sets the S_STORE_NAME value.
	/// </summary>
	[PropertyName("S_STORE_NAME")]
	public String? SStoreName  { get; set; }

	/// <summary>
	///	Gets or sets the S_SUITE_NUMBER value.
	/// </summary>
	[PropertyName("S_SUITE_NUMBER")]
	public String? SSuiteNumber  { get; set; }

	/// <summary>
	///	Gets or sets the S_STORE_ID value.
	/// </summary>
	[PropertyName("S_STORE_ID")]
	public String? SStoreId  { get; set; }

	/// <summary>
	///	Gets or sets the S_COUNTY value.
	/// </summary>
	[PropertyName("S_COUNTY")]
	public String? SCounty  { get; set; }

	/// <summary>
	///	Gets or sets the S_STATE value.
	/// </summary>
	[PropertyName("S_STATE")]
	public String? SState  { get; set; }

	/// <summary>
	///	Gets or sets the S_STORE_SK value.
	/// </summary>
	[PropertyName("S_STORE_SK")]
	public Int32? SStoreSk  { get; set; }

	/// <summary>
	///	Gets or sets the S_STREET_TYPE value.
	/// </summary>
	[PropertyName("S_STREET_TYPE")]
	public String? SStreetType  { get; set; }

	/// <summary>
	///	Gets or sets the S_MARKET_MANAGER value.
	/// </summary>
	[PropertyName("S_MARKET_MANAGER")]
	public String? SMarketManager  { get; set; }

	/// <summary>
	///	Gets or sets the S_MARKET_ID value.
	/// </summary>
	[PropertyName("S_MARKET_ID")]
	public Int32? SMarketId  { get; set; }

	/// <summary>
	///	Gets or sets the S_NUMBER_EMPLOYEES value.
	/// </summary>
	[PropertyName("S_NUMBER_EMPLOYEES")]
	public Int32? SNumberEmployees  { get; set; }

	/// <summary>
	///	Gets or sets the S_MARKET_DESC value.
	/// </summary>
	[PropertyName("S_MARKET_DESC")]
	public String? SMarketDesc  { get; set; }

	/// <summary>
	///	Gets or sets the S_DIVISION_NAME value.
	/// </summary>
	[PropertyName("S_DIVISION_NAME")]
	public String? SDivisionName  { get; set; }

	/// <summary>
	///	Gets or sets the S_CLOSED_DATE_SK value.
	/// </summary>
	[PropertyName("S_CLOSED_DATE_SK")]
	public Int32? SClosedDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the S_REC_END_DATE value.
	/// </summary>
	[PropertyName("S_REC_END_DATE")]
	public DateTime? SRecEndDate  { get; set; }

	/// <summary>
	///	Gets or sets the S_REC_START_DATE value.
	/// </summary>
	[PropertyName("S_REC_START_DATE")]
	public DateTime? SRecStartDate  { get; set; }

	/// <summary>
	///	Gets or sets the S_STREET_NAME value.
	/// </summary>
	[PropertyName("S_STREET_NAME")]
	public String? SStreetName  { get; set; }

	/// <summary>
	///	Gets or sets the S_MANAGER value.
	/// </summary>
	[PropertyName("S_MANAGER")]
	public String? SManager  { get; set; }

	/// <summary>
	///	Gets or sets the S_COMPANY_NAME value.
	/// </summary>
	[PropertyName("S_COMPANY_NAME")]
	public String? SCompanyName  { get; set; }

	/// <summary>
	///	Gets or sets the S_GEOGRAPHY_CLASS value.
	/// </summary>
	[PropertyName("S_GEOGRAPHY_CLASS")]
	public String? SGeographyClass  { get; set; }

	/// <summary>
	///	Gets or sets the S_GMT_OFFSET value.
	/// </summary>
	[PropertyName("S_GMT_OFFSET")]
	public Int32? SGmtOffset  { get; set; }

	/// <summary>
	///	Gets or sets the S_TAX_PRECENTAGE value.
	/// </summary>
	[PropertyName("S_TAX_PRECENTAGE")]
	public Int32? STaxPrecentage  { get; set; }

	/// <summary>
	///	Gets or sets the S_COUNTRY value.
	/// </summary>
	[PropertyName("S_COUNTRY")]
	public String? SCountry  { get; set; }

	/// <summary>
	///	Gets or sets the S_HOURS value.
	/// </summary>
	[PropertyName("S_HOURS")]
	public String? SHours  { get; set; }

	/// <summary>
	///	Gets or sets the S_ZIP value.
	/// </summary>
	[PropertyName("S_ZIP")]
	public String? SZip  { get; set; }

	/// <summary>
	///	Gets or sets the S_COMPANY_ID value.
	/// </summary>
	[PropertyName("S_COMPANY_ID")]
	public Int32? SCompanyId  { get; set; }

	/// <summary>
	///	Gets or sets the S_FLOOR_SPACE value.
	/// </summary>
	[PropertyName("S_FLOOR_SPACE")]
	public Int32? SFloorSpace  { get; set; }

	/// <summary>
	///	Gets or sets the S_DIVISION_ID value.
	/// </summary>
	[PropertyName("S_DIVISION_ID")]
	public Int32? SDivisionId  { get; set; }
}
