# Snowflake.NET
A ORM for using Snowflake in .NET with EntityFramework capabilities, including scaffolding and Linq to Snowflake.

# Notes
This is a library in development; currently working functionality is listed here. Scaffolding is mostly functional, able to generate POCO's and the supporting contextual classes. Relations between databases are not currently supported and are not navigable. In the DbContext class (supported by the SfDbSet class), only the Find(Expression<Func<TEntity, bool>> expression) method is partially complete.

# Getting Started with Scaffolding
To Scaffold a Snowflake database, create a new instace of the Scaffold class:
```
var status = new Scaffolder(
                _connectionSettings, 
                "Snowflake.NET.Tests",
                @"C:\development\Snowflake.NET\test\Snowflake.NET.Tests");
```

Then call the ScaffoldDatabase() method:
`status.ScaffoldDatabase()`

# Making a Database Query
Create an instance of the generated database context class:
```
        var sfc = new SFContext(conn);
        _dataContext = new SnowflakeSampleDataContext(sfc);
```

Navigate to the desired schema and table and pass a query to filter for data:
`var result = _dataContext.TpcdsSf100tcl?.WebSites?.Find(web => web.WebName == "site_0");`

In this instance Find will return an IEnumerable<Websites> object.

