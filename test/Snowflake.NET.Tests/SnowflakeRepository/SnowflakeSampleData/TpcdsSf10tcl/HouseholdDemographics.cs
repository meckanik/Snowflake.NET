using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf10tcl;

/// <summary>
///		Property class for the HOUSEHOLD_DEMOGRAPHICS table.
/// </summary>
[TableName("HOUSEHOLD_DEMOGRAPHICS")]
public class HouseholdDemographics
{
	/// <summary>
	///	Gets or sets the HD_BUY_POTENTIAL value.
	/// </summary>
	[PropertyName("HD_BUY_POTENTIAL")]
	public String? HdBuyPotential  { get; set; }

	/// <summary>
	///	Gets or sets the HD_DEMO_SK value.
	/// </summary>
	[PropertyName("HD_DEMO_SK")]
	public Int32? HdDemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the HD_VEHICLE_COUNT value.
	/// </summary>
	[PropertyName("HD_VEHICLE_COUNT")]
	public Int32? HdVehicleCount  { get; set; }

	/// <summary>
	///	Gets or sets the HD_INCOME_BAND_SK value.
	/// </summary>
	[PropertyName("HD_INCOME_BAND_SK")]
	public Int32? HdIncomeBandSk  { get; set; }

	/// <summary>
	///	Gets or sets the HD_DEP_COUNT value.
	/// </summary>
	[PropertyName("HD_DEP_COUNT")]
	public Int32? HdDepCount  { get; set; }
}
