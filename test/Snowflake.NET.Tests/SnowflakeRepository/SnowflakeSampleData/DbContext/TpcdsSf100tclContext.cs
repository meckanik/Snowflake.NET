using Snowflake.NET.Framework.Entity;
using Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf100tcl;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.DbContext;

/// <summary>
///		SF Schema Context class for the TpcdsSf100tcl schema.
/// </summary>
public class TpcdsSf100tclContext
{
	/// <summary>
	///		Gets or sets the CatalogSales value.
	/// </summary>
	public SFDbSet3<CatalogSales>? CatalogSales  { get; set; }

	/// <summary>
	///		Gets or sets the ShipModes value.
	/// </summary>
	public SFDbSet3<ShipMode>? ShipModes  { get; set; }

	/// <summary>
	///		Gets or sets the CustomerDemographics value.
	/// </summary>
	public SFDbSet3<CustomerDemographics>? CustomerDemographics  { get; set; }

	/// <summary>
	///		Gets or sets the CatalogReturns value.
	/// </summary>
	public SFDbSet3<CatalogReturns>? CatalogReturns  { get; set; }

	/// <summary>
	///		Gets or sets the Customers value.
	/// </summary>
	public SFDbSet3<Customer>? Customers  { get; set; }

	/// <summary>
	///		Gets or sets the Promotions value.
	/// </summary>
	public SFDbSet3<Promotion>? Promotions  { get; set; }

	/// <summary>
	///		Gets or sets the Items value.
	/// </summary>
	public SFDbSet3<Item>? Items  { get; set; }

	/// <summary>
	///		Gets or sets the Stores value.
	/// </summary>
	public SFDbSet3<Store>? Stores  { get; set; }

	/// <summary>
	///		Gets or sets the CatalogPages value.
	/// </summary>
	public SFDbSet3<CatalogPage>? CatalogPages  { get; set; }

	/// <summary>
	///		Gets or sets the WebPages value.
	/// </summary>
	public SFDbSet3<WebPage>? WebPages  { get; set; }

	/// <summary>
	///		Gets or sets the WebSales value.
	/// </summary>
	public SFDbSet3<WebSales>? WebSales  { get; set; }

	/// <summary>
	///		Gets or sets the CallCenters value.
	/// </summary>
	public SFDbSet3<CallCenter>? CallCenters  { get; set; }

	/// <summary>
	///		Gets or sets the Warehouses value.
	/// </summary>
	public SFDbSet3<Warehouse>? Warehouses  { get; set; }

	/// <summary>
	///		Gets or sets the Reasons value.
	/// </summary>
	public SFDbSet3<Reason>? Reasons  { get; set; }

	/// <summary>
	///		Gets or sets the WebReturns value.
	/// </summary>
	public SFDbSet3<WebReturns>? WebReturns  { get; set; }

	/// <summary>
	///		Gets or sets the WebSites value.
	/// </summary>
	public SFDbSet3<WebSite>? WebSites  { get; set; }

	/// <summary>
	///		Gets or sets the CustomerAddress value.
	/// </summary>
	public SFDbSet3<CustomerAddress>? CustomerAddress  { get; set; }

	/// <summary>
	///		Gets or sets the DateDims value.
	/// </summary>
	public SFDbSet3<DateDim>? DateDims  { get; set; }

	/// <summary>
	///		Gets or sets the TimeDims value.
	/// </summary>
	public SFDbSet3<TimeDim>? TimeDims  { get; set; }

	/// <summary>
	///		Gets or sets the HouseholdDemographics value.
	/// </summary>
	public SFDbSet3<HouseholdDemographics>? HouseholdDemographics  { get; set; }

	/// <summary>
	///		Gets or sets the IncomeBands value.
	/// </summary>
	public SFDbSet3<IncomeBand>? IncomeBands  { get; set; }

	/// <summary>
	///		Gets or sets the Inventories value.
	/// </summary>
	public SFDbSet3<Inventory>? Inventories  { get; set; }

	/// <summary>
	///		Gets or sets the StoreSales value.
	/// </summary>
	public SFDbSet3<StoreSales>? StoreSales  { get; set; }

	/// <summary>
	///		Gets or sets the StoreReturns value.
	/// </summary>
	public SFDbSet3<StoreReturns>? StoreReturns  { get; set; }
}
