using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf10tcl;

/// <summary>
///		Property class for the WAREHOUSE table.
/// </summary>
[TableName("TPCDS_SF10TCL.WAREHOUSE")]
public class Warehouse
{
	/// <summary>
	///	Gets or sets the W_WAREHOUSE_SK value.
	/// </summary>
	[PropertyName("W_WAREHOUSE_SK")]
	public Int32? WWarehouseSk  { get; set; }

	/// <summary>
	///	Gets or sets the W_STREET_NUMBER value.
	/// </summary>
	[PropertyName("W_STREET_NUMBER")]
	public String? WStreetNumber  { get; set; }

	/// <summary>
	///	Gets or sets the W_STATE value.
	/// </summary>
	[PropertyName("W_STATE")]
	public String? WState  { get; set; }

	/// <summary>
	///	Gets or sets the W_COUNTRY value.
	/// </summary>
	[PropertyName("W_COUNTRY")]
	public String? WCountry  { get; set; }

	/// <summary>
	///	Gets or sets the W_COUNTY value.
	/// </summary>
	[PropertyName("W_COUNTY")]
	public String? WCounty  { get; set; }

	/// <summary>
	///	Gets or sets the W_WAREHOUSE_ID value.
	/// </summary>
	[PropertyName("W_WAREHOUSE_ID")]
	public String? WWarehouseId  { get; set; }

	/// <summary>
	///	Gets or sets the W_GMT_OFFSET value.
	/// </summary>
	[PropertyName("W_GMT_OFFSET")]
	public Decimal? WGmtOffset  { get; set; }

	/// <summary>
	///	Gets or sets the W_STREET_TYPE value.
	/// </summary>
	[PropertyName("W_STREET_TYPE")]
	public String? WStreetType  { get; set; }

	/// <summary>
	///	Gets or sets the W_WAREHOUSE_SQ_FT value.
	/// </summary>
	[PropertyName("W_WAREHOUSE_SQ_FT")]
	public Int32? WWarehouseSqFt  { get; set; }

	/// <summary>
	///	Gets or sets the W_CITY value.
	/// </summary>
	[PropertyName("W_CITY")]
	public String? WCity  { get; set; }

	/// <summary>
	///	Gets or sets the W_SUITE_NUMBER value.
	/// </summary>
	[PropertyName("W_SUITE_NUMBER")]
	public String? WSuiteNumber  { get; set; }

	/// <summary>
	///	Gets or sets the W_STREET_NAME value.
	/// </summary>
	[PropertyName("W_STREET_NAME")]
	public String? WStreetName  { get; set; }

	/// <summary>
	///	Gets or sets the W_WAREHOUSE_NAME value.
	/// </summary>
	[PropertyName("W_WAREHOUSE_NAME")]
	public String? WWarehouseName  { get; set; }

	/// <summary>
	///	Gets or sets the W_ZIP value.
	/// </summary>
	[PropertyName("W_ZIP")]
	public String? WZip  { get; set; }
}
