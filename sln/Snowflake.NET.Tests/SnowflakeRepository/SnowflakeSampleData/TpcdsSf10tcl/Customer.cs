using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf10tcl;

/// <summary>
///		Property class for the CUSTOMER table.
/// </summary>
[TableName("CUSTOMER")]
public class Customer
{
	/// <summary>
	///	Gets or sets the C_BIRTH_COUNTRY value.
	/// </summary>
	[PropertyName("C_BIRTH_COUNTRY")]
	public String? CBirthCountry  { get; set; }

	/// <summary>
	///	Gets or sets the C_LAST_NAME value.
	/// </summary>
	[PropertyName("C_LAST_NAME")]
	public String? CLastName  { get; set; }

	/// <summary>
	///	Gets or sets the C_LAST_REVIEW_DATE value.
	/// </summary>
	[PropertyName("C_LAST_REVIEW_DATE")]
	public String? CLastReviewDate  { get; set; }

	/// <summary>
	///	Gets or sets the C_FIRST_SALES_DATE_SK value.
	/// </summary>
	[PropertyName("C_FIRST_SALES_DATE_SK")]
	public Int32? CFirstSalesDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the C_BIRTH_DAY value.
	/// </summary>
	[PropertyName("C_BIRTH_DAY")]
	public Int32? CBirthDay  { get; set; }

	/// <summary>
	///	Gets or sets the C_FIRST_SHIPTO_DATE_SK value.
	/// </summary>
	[PropertyName("C_FIRST_SHIPTO_DATE_SK")]
	public Int32? CFirstShiptoDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the C_LOGIN value.
	/// </summary>
	[PropertyName("C_LOGIN")]
	public String? CLogin  { get; set; }

	/// <summary>
	///	Gets or sets the C_CUSTOMER_SK value.
	/// </summary>
	[PropertyName("C_CUSTOMER_SK")]
	public Int32? CCustomerSk  { get; set; }

	/// <summary>
	///	Gets or sets the C_BIRTH_MONTH value.
	/// </summary>
	[PropertyName("C_BIRTH_MONTH")]
	public Int32? CBirthMonth  { get; set; }

	/// <summary>
	///	Gets or sets the C_SALUTATION value.
	/// </summary>
	[PropertyName("C_SALUTATION")]
	public String? CSalutation  { get; set; }

	/// <summary>
	///	Gets or sets the C_BIRTH_YEAR value.
	/// </summary>
	[PropertyName("C_BIRTH_YEAR")]
	public Int32? CBirthYear  { get; set; }

	/// <summary>
	///	Gets or sets the C_EMAIL_ADDRESS value.
	/// </summary>
	[PropertyName("C_EMAIL_ADDRESS")]
	public String? CEmailAddress  { get; set; }

	/// <summary>
	///	Gets or sets the C_CUSTOMER_ID value.
	/// </summary>
	[PropertyName("C_CUSTOMER_ID")]
	public String? CCustomerId  { get; set; }

	/// <summary>
	///	Gets or sets the C_PREFERRED_CUST_FLAG value.
	/// </summary>
	[PropertyName("C_PREFERRED_CUST_FLAG")]
	public String? CPreferredCustFlag  { get; set; }

	/// <summary>
	///	Gets or sets the C_FIRST_NAME value.
	/// </summary>
	[PropertyName("C_FIRST_NAME")]
	public String? CFirstName  { get; set; }

	/// <summary>
	///	Gets or sets the C_CURRENT_HDEMO_SK value.
	/// </summary>
	[PropertyName("C_CURRENT_HDEMO_SK")]
	public Int32? CCurrentHdemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the C_CURRENT_ADDR_SK value.
	/// </summary>
	[PropertyName("C_CURRENT_ADDR_SK")]
	public Int32? CCurrentAddrSk  { get; set; }

	/// <summary>
	///	Gets or sets the C_CURRENT_CDEMO_SK value.
	/// </summary>
	[PropertyName("C_CURRENT_CDEMO_SK")]
	public Int32? CCurrentCdemoSk  { get; set; }
}
