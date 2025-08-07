using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf10tcl;

/// <summary>
///		Property class for the CUSTOMER_DEMOGRAPHICS table.
/// </summary>
[TableName("CUSTOMER_DEMOGRAPHICS")]
public class CustomerDemographics
{
	/// <summary>
	///	Gets or sets the CD_DEP_COLLEGE_COUNT value.
	/// </summary>
	[PropertyName("CD_DEP_COLLEGE_COUNT")]
	public Int32? CdDepCollegeCount  { get; set; }

	/// <summary>
	///	Gets or sets the CD_DEP_EMPLOYED_COUNT value.
	/// </summary>
	[PropertyName("CD_DEP_EMPLOYED_COUNT")]
	public Int32? CdDepEmployedCount  { get; set; }

	/// <summary>
	///	Gets or sets the CD_DEP_COUNT value.
	/// </summary>
	[PropertyName("CD_DEP_COUNT")]
	public Int32? CdDepCount  { get; set; }

	/// <summary>
	///	Gets or sets the CD_PURCHASE_ESTIMATE value.
	/// </summary>
	[PropertyName("CD_PURCHASE_ESTIMATE")]
	public Int32? CdPurchaseEstimate  { get; set; }

	/// <summary>
	///	Gets or sets the CD_CREDIT_RATING value.
	/// </summary>
	[PropertyName("CD_CREDIT_RATING")]
	public String? CdCreditRating  { get; set; }

	/// <summary>
	///	Gets or sets the CD_GENDER value.
	/// </summary>
	[PropertyName("CD_GENDER")]
	public String? CdGender  { get; set; }

	/// <summary>
	///	Gets or sets the CD_MARITAL_STATUS value.
	/// </summary>
	[PropertyName("CD_MARITAL_STATUS")]
	public String? CdMaritalStatus  { get; set; }

	/// <summary>
	///	Gets or sets the CD_DEMO_SK value.
	/// </summary>
	[PropertyName("CD_DEMO_SK")]
	public Int32? CdDemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the CD_EDUCATION_STATUS value.
	/// </summary>
	[PropertyName("CD_EDUCATION_STATUS")]
	public String? CdEducationStatus  { get; set; }
}
