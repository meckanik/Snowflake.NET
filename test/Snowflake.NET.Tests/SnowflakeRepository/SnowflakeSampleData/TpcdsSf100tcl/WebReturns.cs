using Snowflake.NET.Attributes;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpcdsSf100tcl;

/// <summary>
///		Property class for the WEB_RETURNS table.
/// </summary>
[TableName("TPCDS_SF100TCL.WEB_RETURNS")]
public class WebReturns
{
	/// <summary>
	///	Gets or sets the WR_ACCOUNT_CREDIT value.
	/// </summary>
	[PropertyName("WR_ACCOUNT_CREDIT")]
	public Decimal? WrAccountCredit  { get; set; }

	/// <summary>
	///	Gets or sets the WR_REASON_SK value.
	/// </summary>
	[PropertyName("WR_REASON_SK")]
	public Int32? WrReasonSk  { get; set; }

	/// <summary>
	///	Gets or sets the WR_RETURNING_ADDR_SK value.
	/// </summary>
	[PropertyName("WR_RETURNING_ADDR_SK")]
	public Int32? WrReturningAddrSk  { get; set; }

	/// <summary>
	///	Gets or sets the WR_ITEM_SK value.
	/// </summary>
	[PropertyName("WR_ITEM_SK")]
	public Int32? WrItemSk  { get; set; }

	/// <summary>
	///	Gets or sets the WR_RETURNING_HDEMO_SK value.
	/// </summary>
	[PropertyName("WR_RETURNING_HDEMO_SK")]
	public Int32? WrReturningHdemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the WR_RETURNING_CDEMO_SK value.
	/// </summary>
	[PropertyName("WR_RETURNING_CDEMO_SK")]
	public Int32? WrReturningCdemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the WR_REFUNDED_CDEMO_SK value.
	/// </summary>
	[PropertyName("WR_REFUNDED_CDEMO_SK")]
	public Int32? WrRefundedCdemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the WR_RETURN_TAX value.
	/// </summary>
	[PropertyName("WR_RETURN_TAX")]
	public Decimal? WrReturnTax  { get; set; }

	/// <summary>
	///	Gets or sets the WR_REFUNDED_HDEMO_SK value.
	/// </summary>
	[PropertyName("WR_REFUNDED_HDEMO_SK")]
	public Int32? WrRefundedHdemoSk  { get; set; }

	/// <summary>
	///	Gets or sets the WR_RETURNED_DATE_SK value.
	/// </summary>
	[PropertyName("WR_RETURNED_DATE_SK")]
	public Int32? WrReturnedDateSk  { get; set; }

	/// <summary>
	///	Gets or sets the WR_RETURNING_CUSTOMER_SK value.
	/// </summary>
	[PropertyName("WR_RETURNING_CUSTOMER_SK")]
	public Int32? WrReturningCustomerSk  { get; set; }

	/// <summary>
	///	Gets or sets the WR_REFUNDED_CUSTOMER_SK value.
	/// </summary>
	[PropertyName("WR_REFUNDED_CUSTOMER_SK")]
	public Int32? WrRefundedCustomerSk  { get; set; }

	/// <summary>
	///	Gets or sets the WR_REVERSED_CHARGE value.
	/// </summary>
	[PropertyName("WR_REVERSED_CHARGE")]
	public Decimal? WrReversedCharge  { get; set; }

	/// <summary>
	///	Gets or sets the WR_REFUNDED_CASH value.
	/// </summary>
	[PropertyName("WR_REFUNDED_CASH")]
	public Decimal? WrRefundedCash  { get; set; }

	/// <summary>
	///	Gets or sets the WR_FEE value.
	/// </summary>
	[PropertyName("WR_FEE")]
	public Decimal? WrFee  { get; set; }

	/// <summary>
	///	Gets or sets the WR_REFUNDED_ADDR_SK value.
	/// </summary>
	[PropertyName("WR_REFUNDED_ADDR_SK")]
	public Int32? WrRefundedAddrSk  { get; set; }

	/// <summary>
	///	Gets or sets the WR_RETURN_QUANTITY value.
	/// </summary>
	[PropertyName("WR_RETURN_QUANTITY")]
	public Int32? WrReturnQuantity  { get; set; }

	/// <summary>
	///	Gets or sets the WR_RETURN_SHIP_COST value.
	/// </summary>
	[PropertyName("WR_RETURN_SHIP_COST")]
	public Decimal? WrReturnShipCost  { get; set; }

	/// <summary>
	///	Gets or sets the WR_NET_LOSS value.
	/// </summary>
	[PropertyName("WR_NET_LOSS")]
	public Decimal? WrNetLoss  { get; set; }

	/// <summary>
	///	Gets or sets the WR_RETURN_AMT value.
	/// </summary>
	[PropertyName("WR_RETURN_AMT")]
	public Decimal? WrReturnAmt  { get; set; }

	/// <summary>
	///	Gets or sets the WR_RETURN_AMT_INC_TAX value.
	/// </summary>
	[PropertyName("WR_RETURN_AMT_INC_TAX")]
	public Decimal? WrReturnAmtIncTax  { get; set; }

	/// <summary>
	///	Gets or sets the WR_ORDER_NUMBER value.
	/// </summary>
	[PropertyName("WR_ORDER_NUMBER")]
	public Int32? WrOrderNumber  { get; set; }

	/// <summary>
	///	Gets or sets the WR_RETURNED_TIME_SK value.
	/// </summary>
	[PropertyName("WR_RETURNED_TIME_SK")]
	public Int32? WrReturnedTimeSk  { get; set; }

	/// <summary>
	///	Gets or sets the WR_WEB_PAGE_SK value.
	/// </summary>
	[PropertyName("WR_WEB_PAGE_SK")]
	public Int32? WrWebPageSk  { get; set; }
}
