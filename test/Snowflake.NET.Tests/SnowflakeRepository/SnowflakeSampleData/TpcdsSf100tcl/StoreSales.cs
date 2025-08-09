using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf100tcl;

/// <summary>
///		Property class for the STORE_SALES table.
/// </summary>
[TableName("TPCDS_SF100TCL.STORE_SALES")]
public class StoreSales
{
	/// <summary>
	///	Gets or sets the SS_PROMO_SK value.
	/// </summary>
	[PropertyName("SS_PROMO_SK")]
	public Int32? SsPromoSk  { get; set; }

	/// <summary>
	///	Gets or sets the SS_COUPON_AMT value.
	/// </summary>
	[PropertyName("SS_COUPON_AMT")]
	public Decimal? SsCouponAmt  { get; set; }

	/// <summary>
	///	Gets or sets the SS_QUANTITY value.
	/// </summary>
	[PropertyName("SS_QUANTITY")]
	public Int32? SsQuantity  { get; set; }

	/// <summary>
	///	Gets or sets the SS_CDEMO_SK value.
	/// </summary>
	[PropertyName("SS_CDEMO_SK")]
	public Int32? SsCdemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the SS_ADDR_SK value.
	/// </summary>
	[PropertyName("SS_ADDR_SK")]
	public Int32? SsAddrSk  { get; set; }

	/// <summary>
	///	Gets or sets the SS_TICKET_NUMBER value.
	/// </summary>
	[PropertyName("SS_TICKET_NUMBER")]
	public Int32? SsTicketNumber  { get; set; }

	/// <summary>
	///	Gets or sets the SS_SOLD_DATE_SK value.
	/// </summary>
	[PropertyName("SS_SOLD_DATE_SK")]
	public Int32? SsSoldDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the SS_EXT_WHOLESALE_COST value.
	/// </summary>
	[PropertyName("SS_EXT_WHOLESALE_COST")]
	public Decimal? SsExtWholesaleCost  { get; set; }

	/// <summary>
	///	Gets or sets the SS_EXT_DISCOUNT_AMT value.
	/// </summary>
	[PropertyName("SS_EXT_DISCOUNT_AMT")]
	public Decimal? SsExtDiscountAmt  { get; set; }

	/// <summary>
	///	Gets or sets the SS_NET_PAID_INC_TAX value.
	/// </summary>
	[PropertyName("SS_NET_PAID_INC_TAX")]
	public Decimal? SsNetPaidIncTax  { get; set; }

	/// <summary>
	///	Gets or sets the SS_EXT_LIST_PRICE value.
	/// </summary>
	[PropertyName("SS_EXT_LIST_PRICE")]
	public Decimal? SsExtListPrice  { get; set; }

	/// <summary>
	///	Gets or sets the SS_WHOLESALE_COST value.
	/// </summary>
	[PropertyName("SS_WHOLESALE_COST")]
	public Decimal? SsWholesaleCost  { get; set; }

	/// <summary>
	///	Gets or sets the SS_STORE_SK value.
	/// </summary>
	[PropertyName("SS_STORE_SK")]
	public Int32? SsStoreSk  { get; set; }

	/// <summary>
	///	Gets or sets the SS_LIST_PRICE value.
	/// </summary>
	[PropertyName("SS_LIST_PRICE")]
	public Decimal? SsListPrice  { get; set; }

	/// <summary>
	///	Gets or sets the SS_NET_PAID value.
	/// </summary>
	[PropertyName("SS_NET_PAID")]
	public Decimal? SsNetPaid  { get; set; }

	/// <summary>
	///	Gets or sets the SS_SALES_PRICE value.
	/// </summary>
	[PropertyName("SS_SALES_PRICE")]
	public Decimal? SsSalesPrice  { get; set; }

	/// <summary>
	///	Gets or sets the SS_HDEMO_SK value.
	/// </summary>
	[PropertyName("SS_HDEMO_SK")]
	public Int32? SsHdemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the SS_NET_PROFIT value.
	/// </summary>
	[PropertyName("SS_NET_PROFIT")]
	public Decimal? SsNetProfit  { get; set; }

	/// <summary>
	///	Gets or sets the SS_CUSTOMER_SK value.
	/// </summary>
	[PropertyName("SS_CUSTOMER_SK")]
	public Int32? SsCustomerSk  { get; set; }

	/// <summary>
	///	Gets or sets the SS_ITEM_SK value.
	/// </summary>
	[PropertyName("SS_ITEM_SK")]
	public Int32? SsItemSk  { get; set; }

	/// <summary>
	///	Gets or sets the SS_SOLD_TIME_SK value.
	/// </summary>
	[PropertyName("SS_SOLD_TIME_SK")]
	public Int32? SsSoldTimeSk  { get; set; }

	/// <summary>
	///	Gets or sets the SS_EXT_SALES_PRICE value.
	/// </summary>
	[PropertyName("SS_EXT_SALES_PRICE")]
	public Decimal? SsExtSalesPrice  { get; set; }

	/// <summary>
	///	Gets or sets the SS_EXT_TAX value.
	/// </summary>
	[PropertyName("SS_EXT_TAX")]
	public Decimal? SsExtTax  { get; set; }
}
