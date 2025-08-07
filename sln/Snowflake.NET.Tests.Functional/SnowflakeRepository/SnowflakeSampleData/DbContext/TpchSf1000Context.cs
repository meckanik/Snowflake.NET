using Snowflake.NET.Framework.Entity;
using Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.TpchSf1000;

namespace Snowflake.NET.Tests.SnowflakeRepository.SnowflakeSampleData.DbContext;

/// <summary>
///		SF Schema Context class for the TpchSf1000 schema.
/// </summary>
public class TpchSf1000Context
{
	/// <summary>
	///		Gets or sets the Customers value.
	/// </summary>
	public SFDbSet<Customer>? Customers  { get; set; }

	/// <summary>
	///		Gets or sets the Regions value.
	/// </summary>
	public SFDbSet<Region>? Regions  { get; set; }

	/// <summary>
	///		Gets or sets the Orders value.
	/// </summary>
	public SFDbSet<Orders>? Orders  { get; set; }

	/// <summary>
	///		Gets or sets the Parts value.
	/// </summary>
	public SFDbSet<Part>? Parts  { get; set; }

	/// <summary>
	///		Gets or sets the Suppliers value.
	/// </summary>
	public SFDbSet<Supplier>? Suppliers  { get; set; }

	/// <summary>
	///		Gets or sets the Partsupps value.
	/// </summary>
	public SFDbSet<Partsupp>? Partsupps  { get; set; }

	/// <summary>
	///		Gets or sets the Lineitems value.
	/// </summary>
	public SFDbSet<Lineitem>? Lineitems  { get; set; }

	/// <summary>
	///		Gets or sets the Nations value.
	/// </summary>
	public SFDbSet<Nation>? Nations  { get; set; }
}
