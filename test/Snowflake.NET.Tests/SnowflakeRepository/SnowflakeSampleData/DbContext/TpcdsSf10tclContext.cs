using Snowflake.NET.Framework.Entity;
using Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf10tcl;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.DbContext;

/// <summary>
///		SF Schema Context class for the TpcdsSf10tcl schema.
/// </summary>
public class TpcdsSf10tclContext
{
	/// <summary>
	///		Gets or sets the Stores value.
	/// </summary>
	public SFDbSet<Store>? Stores  { get; set; }

	/// <summary>
	///		Gets or sets the Promotions value.
	/// </summary>
	public SFDbSet<Promotion>? Promotions  { get; set; }

	/// <summary>
	///		Gets or sets the CatalogPages value.
	/// </summary>
	public SFDbSet<CatalogPage>? CatalogPages  { get; set; }

	/// <summary>
	///		Gets or sets the Reasons value.
	/// </summary>
	public SFDbSet<Reason>? Reasons  { get; set; }

	/// <summary>
	///		Gets or sets the CatalogSales value.
	/// </summary>
	public SFDbSet<CatalogSales>? CatalogSales  { get; set; }

	/// <summary>
	///		Gets or sets the StoreSales value.
	/// </summary>
	public SFDbSet<StoreSales>? StoreSales  { get; set; }

	/// <summary>
	///		Gets or sets the DateDims value.
	/// </summary>
	public SFDbSet<DateDim>? DateDims  { get; set; }

	/// <summary>
	///		Gets or sets the CustomerDemographics value.
	/// </summary>
	public SFDbSet<CustomerDemographics>? CustomerDemographics  { get; set; }

	/// <summary>
	///		Gets or sets the WebReturns value.
	/// </summary>
	public SFDbSet<WebReturns>? WebReturns  { get; set; }

	/// <summary>
	///		Gets or sets the Items value.
	/// </summary>
	public SFDbSet<Item>? Items  { get; set; }

	/// <summary>
	///		Gets or sets the HouseholdDemographics value.
	/// </summary>
	public SFDbSet<HouseholdDemographics>? HouseholdDemographics  { get; set; }

	/// <summary>
	///		Gets or sets the CallCenters value.
	/// </summary>
	public SFDbSet<CallCenter>? CallCenters  { get; set; }

	/// <summary>
	///		Gets or sets the Customers value.
	/// </summary>
	public SFDbSet<Customer>? Customers  { get; set; }

	/// <summary>
	///		Gets or sets the CustomerAddress value.
	/// </summary>
	public SFDbSet<CustomerAddress>? CustomerAddress  { get; set; }

	/// <summary>
	///		Gets or sets the WebPages value.
	/// </summary>
	public SFDbSet<WebPage>? WebPages  { get; set; }

	/// <summary>
	///		Gets or sets the WebSites value.
	/// </summary>
	public SFDbSet<WebSite>? WebSites  { get; set; }

	/// <summary>
	///		Gets or sets the CatalogReturns value.
	/// </summary>
	public SFDbSet<CatalogReturns>? CatalogReturns  { get; set; }

	/// <summary>
	///		Gets or sets the IncomeBands value.
	/// </summary>
	public SFDbSet<IncomeBand>? IncomeBands  { get; set; }

	/// <summary>
	///		Gets or sets the ShipModes value.
	/// </summary>
	public SFDbSet<ShipMode>? ShipModes  { get; set; }

	/// <summary>
	///		Gets or sets the StoreReturns value.
	/// </summary>
	public SFDbSet<StoreReturns>? StoreReturns  { get; set; }

	/// <summary>
	///		Gets or sets the Warehouses value.
	/// </summary>
	public SFDbSet<Warehouse>? Warehouses  { get; set; }

	/// <summary>
	///		Gets or sets the Inventories value.
	/// </summary>
	public SFDbSet<Inventory>? Inventories  { get; set; }

	/// <summary>
	///		Gets or sets the WebSales value.
	/// </summary>
	public SFDbSet<WebSales>? WebSales  { get; set; }

	/// <summary>
	///		Gets or sets the TimeDims value.
	/// </summary>
	public SFDbSet<TimeDim>? TimeDims  { get; set; }
}
