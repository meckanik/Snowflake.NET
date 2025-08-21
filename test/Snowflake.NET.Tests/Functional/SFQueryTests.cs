using Snowflake.NET.Framework.Context;
using Snowflake.NET.Tests.SnowflakeRepository;

namespace Snowflake.NET.Tests.Functional;

[TestFixture]
public class SFQueryTests
{
    public TestContext? TestContext { get; set; }

    private static SnowflakeSampleDataContext _dataContext;

    [SetUp]
    public void Setup()
    {
        var conn = TestContext.Parameters["ConnectionString"]!;
        var sfc = new SFContext(conn);
        _dataContext = new SnowflakeSampleDataContext(sfc);
    }

    [Test]
    public async Task Test_ExecuteBasicLinqQuery()
    {
        var result = await _dataContext.TpcdsSf100tcl?.WebSites?.Find(web => web.WebName == "site_0")!;

        Assert.That(result, Is.Not.Null);
        Assert.That(result.Count(), Is.GreaterThan(1));
    }

    [Test]
    public async Task Test_LinqQueryWithMethod()
    {
        var result = await _dataContext.TpcdsSf100tcl?.WebSites?.Find(web => string.Equals("SiTe_0", web.WebName, StringComparison.OrdinalIgnoreCase))!;

        Assert.That(result, Is.Not.Null);
        Assert.That(result.Count(), Is.GreaterThan(1));
    }
}
