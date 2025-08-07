using Snowflake.NET.Models;
using Snowflake.NET.Validation;

namespace Snowflake.NET.Scaffold.Scaffolding;

/// <summary>
///     Generates classes for scaffolding operations.
/// </summary>
internal class ClassGenerator
{
    /// <summary>
    ///     Generates the POCO and context classes for scaffolding operations.
    /// </summary>
    /// <param name="repositoryPath">The physical location to place the generated files.</param>
    /// <param name="repositoryNamespace">The namespace to use for the generated files.</param>
    /// <param name="dbInfo">The INFORMATION_SCHEMA table information.</param>
    internal static void Generate(
        string repositoryPath,
        string repositoryNamespace,
        IEnumerable<TableData> dbInfo)
    {
        PropertyValidators.ValidateArgument(dbInfo);

        // generate the POCOs
        PocoGenerator.Generate(repositoryPath, repositoryNamespace, dbInfo);
        // generate the context classes
        ContextGenerator.Generate(repositoryPath, repositoryNamespace, dbInfo);
    }
}
