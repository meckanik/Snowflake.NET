using Snowflake.NET.Framework.Entity;
using Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpchSf1;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.DbContext;

/// <summary>
///		SF Schema Context class for the TpchSf1 schema.
/// </summary>
public class TpchSf1Context
{
	/// <summary>
	///		Gets or sets the Nations value.
	/// </summary>
	public SFDbSet3<Nation>? Nations  { get; set; }

	/// <summary>
	///		Gets or sets the Partsupps value.
	/// </summary>
	public SFDbSet3<Partsupp>? Partsupps  { get; set; }

	/// <summary>
	///		Gets or sets the Suppliers value.
	/// </summary>
	public SFDbSet3<Supplier>? Suppliers  { get; set; }

	/// <summary>
	///		Gets or sets the Regions value.
	/// </summary>
	public SFDbSet3<Region>? Regions  { get; set; }

	/// <summary>
	///		Gets or sets the Orders value.
	/// </summary>
	public SFDbSet3<Orders>? Orders  { get; set; }

	/// <summary>
	///		Gets or sets the Parts value.
	/// </summary>
	public SFDbSet3<Part>? Parts  { get; set; }

	/// <summary>
	///		Gets or sets the Lineitems value.
	/// </summary>
	public SFDbSet3<Lineitem>? Lineitems  { get; set; }

	/// <summary>
	///		Gets or sets the Customers value.
	/// </summary>
	public SFDbSet3<Customer>? Customers  { get; set; }
}
