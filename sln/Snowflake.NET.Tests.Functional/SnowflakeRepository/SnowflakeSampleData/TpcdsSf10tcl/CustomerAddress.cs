using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf10tcl;

/// <summary>
///		Property class for the CUSTOMER_ADDRESS table.
/// </summary>
[TableName("CUSTOMER_ADDRESS")]
public class CustomerAddress
{
	/// <summary>
	///	Gets or sets the CA_ZIP value.
	/// </summary>
	[PropertyName("CA_ZIP")]
	public String? CaZip  { get; set; }

	/// <summary>
	///	Gets or sets the CA_ADDRESS_SK value.
	/// </summary>
	[PropertyName("CA_ADDRESS_SK")]
	public Int32? CaAddressSk  { get; set; }

	/// <summary>
	///	Gets or sets the CA_COUNTY value.
	/// </summary>
	[PropertyName("CA_COUNTY")]
	public String? CaCounty  { get; set; }

	/// <summary>
	///	Gets or sets the CA_COUNTRY value.
	/// </summary>
	[PropertyName("CA_COUNTRY")]
	public String? CaCountry  { get; set; }

	/// <summary>
	///	Gets or sets the CA_CITY value.
	/// </summary>
	[PropertyName("CA_CITY")]
	public String? CaCity  { get; set; }

	/// <summary>
	///	Gets or sets the CA_STREET_NAME value.
	/// </summary>
	[PropertyName("CA_STREET_NAME")]
	public String? CaStreetName  { get; set; }

	/// <summary>
	///	Gets or sets the CA_STREET_NUMBER value.
	/// </summary>
	[PropertyName("CA_STREET_NUMBER")]
	public String? CaStreetNumber  { get; set; }

	/// <summary>
	///	Gets or sets the CA_GMT_OFFSET value.
	/// </summary>
	[PropertyName("CA_GMT_OFFSET")]
	public Int32? CaGmtOffset  { get; set; }

	/// <summary>
	///	Gets or sets the CA_SUITE_NUMBER value.
	/// </summary>
	[PropertyName("CA_SUITE_NUMBER")]
	public String? CaSuiteNumber  { get; set; }

	/// <summary>
	///	Gets or sets the CA_STREET_TYPE value.
	/// </summary>
	[PropertyName("CA_STREET_TYPE")]
	public String? CaStreetType  { get; set; }

	/// <summary>
	///	Gets or sets the CA_LOCATION_TYPE value.
	/// </summary>
	[PropertyName("CA_LOCATION_TYPE")]
	public String? CaLocationType  { get; set; }

	/// <summary>
	///	Gets or sets the CA_STATE value.
	/// </summary>
	[PropertyName("CA_STATE")]
	public String? CaState  { get; set; }

	/// <summary>
	///	Gets or sets the CA_ADDRESS_ID value.
	/// </summary>
	[PropertyName("CA_ADDRESS_ID")]
	public String? CaAddressId  { get; set; }
}
