using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf10tcl;

/// <summary>
///		Property class for the CATALOG_RETURNS table.
/// </summary>
[TableName("CATALOG_RETURNS")]
public class CatalogReturns
{
	/// <summary>
	///	Gets or sets the CR_REVERSED_CHARGE value.
	/// </summary>
	[PropertyName("CR_REVERSED_CHARGE")]
	public Int32? CrReversedCharge  { get; set; }

	/// <summary>
	///	Gets or sets the CR_RETURN_SHIP_COST value.
	/// </summary>
	[PropertyName("CR_RETURN_SHIP_COST")]
	public Int32? CrReturnShipCost  { get; set; }

	/// <summary>
	///	Gets or sets the CR_RETURN_AMT_INC_TAX value.
	/// </summary>
	[PropertyName("CR_RETURN_AMT_INC_TAX")]
	public Int32? CrReturnAmtIncTax  { get; set; }

	/// <summary>
	///	Gets or sets the CR_RETURN_AMOUNT value.
	/// </summary>
	[PropertyName("CR_RETURN_AMOUNT")]
	public Int32? CrReturnAmount  { get; set; }

	/// <summary>
	///	Gets or sets the CR_RETURNING_ADDR_SK value.
	/// </summary>
	[PropertyName("CR_RETURNING_ADDR_SK")]
	public Int32? CrReturningAddrSk  { get; set; }

	/// <summary>
	///	Gets or sets the CR_RETURN_TAX value.
	/// </summary>
	[PropertyName("CR_RETURN_TAX")]
	public Int32? CrReturnTax  { get; set; }

	/// <summary>
	///	Gets or sets the CR_CATALOG_PAGE_SK value.
	/// </summary>
	[PropertyName("CR_CATALOG_PAGE_SK")]
	public Int32? CrCatalogPageSk  { get; set; }

	/// <summary>
	///	Gets or sets the CR_RETURNED_TIME_SK value.
	/// </summary>
	[PropertyName("CR_RETURNED_TIME_SK")]
	public Int32? CrReturnedTimeSk  { get; set; }

	/// <summary>
	///	Gets or sets the CR_REFUNDED_CDEMO_SK value.
	/// </summary>
	[PropertyName("CR_REFUNDED_CDEMO_SK")]
	public Int32? CrRefundedCdemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the CR_WAREHOUSE_SK value.
	/// </summary>
	[PropertyName("CR_WAREHOUSE_SK")]
	public Int32? CrWarehouseSk  { get; set; }

	/// <summary>
	///	Gets or sets the CR_RETURNING_CUSTOMER_SK value.
	/// </summary>
	[PropertyName("CR_RETURNING_CUSTOMER_SK")]
	public Int32? CrReturningCustomerSk  { get; set; }

	/// <summary>
	///	Gets or sets the CR_REFUNDED_CASH value.
	/// </summary>
	[PropertyName("CR_REFUNDED_CASH")]
	public Int32? CrRefundedCash  { get; set; }

	/// <summary>
	///	Gets or sets the CR_REASON_SK value.
	/// </summary>
	[PropertyName("CR_REASON_SK")]
	public Int32? CrReasonSk  { get; set; }

	/// <summary>
	///	Gets or sets the CR_REFUNDED_ADDR_SK value.
	/// </summary>
	[PropertyName("CR_REFUNDED_ADDR_SK")]
	public Int32? CrRefundedAddrSk  { get; set; }

	/// <summary>
	///	Gets or sets the CR_NET_LOSS value.
	/// </summary>
	[PropertyName("CR_NET_LOSS")]
	public Int32? CrNetLoss  { get; set; }

	/// <summary>
	///	Gets or sets the CR_REFUNDED_CUSTOMER_SK value.
	/// </summary>
	[PropertyName("CR_REFUNDED_CUSTOMER_SK")]
	public Int32? CrRefundedCustomerSk  { get; set; }

	/// <summary>
	///	Gets or sets the CR_SHIP_MODE_SK value.
	/// </summary>
	[PropertyName("CR_SHIP_MODE_SK")]
	public Int32? CrShipModeSk  { get; set; }

	/// <summary>
	///	Gets or sets the CR_RETURNED_DATE_SK value.
	/// </summary>
	[PropertyName("CR_RETURNED_DATE_SK")]
	public Int32? CrReturnedDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the CR_REFUNDED_HDEMO_SK value.
	/// </summary>
	[PropertyName("CR_REFUNDED_HDEMO_SK")]
	public Int32? CrRefundedHdemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the CR_ORDER_NUMBER value.
	/// </summary>
	[PropertyName("CR_ORDER_NUMBER")]
	public Int32? CrOrderNumber  { get; set; }

	/// <summary>
	///	Gets or sets the CR_FEE value.
	/// </summary>
	[PropertyName("CR_FEE")]
	public Int32? CrFee  { get; set; }

	/// <summary>
	///	Gets or sets the CR_CALL_CENTER_SK value.
	/// </summary>
	[PropertyName("CR_CALL_CENTER_SK")]
	public Int32? CrCallCenterSk  { get; set; }

	/// <summary>
	///	Gets or sets the CR_RETURNING_HDEMO_SK value.
	/// </summary>
	[PropertyName("CR_RETURNING_HDEMO_SK")]
	public Int32? CrReturningHdemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the CR_STORE_CREDIT value.
	/// </summary>
	[PropertyName("CR_STORE_CREDIT")]
	public Int32? CrStoreCredit  { get; set; }

	/// <summary>
	///	Gets or sets the CR_ITEM_SK value.
	/// </summary>
	[PropertyName("CR_ITEM_SK")]
	public Int32? CrItemSk  { get; set; }

	/// <summary>
	///	Gets or sets the CR_RETURNING_CDEMO_SK value.
	/// </summary>
	[PropertyName("CR_RETURNING_CDEMO_SK")]
	public Int32? CrReturningCdemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the CR_RETURN_QUANTITY value.
	/// </summary>
	[PropertyName("CR_RETURN_QUANTITY")]
	public Int32? CrReturnQuantity  { get; set; }
}
