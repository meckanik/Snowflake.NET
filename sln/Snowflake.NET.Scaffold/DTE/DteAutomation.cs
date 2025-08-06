namespace Snowflake.NET.Scaffold.DTE;

/// <summary>
///     Contains methods for Visual Studio automation.
/// </summary>
public static class DteAutomation
{
    /// <summary>
    ///     Refreshes Visual Studio's open projects.
    /// </summary>
    /// <param name="solutions">The collection of active instances on the current machine.</param>
    /// <returns>True, if successful.</returns>
    public static bool RefreshProjects(IEnumerable<EnvDTE.DTE> solutions)
    {
        var result = false;
        if (solutions is not null)
        {
            foreach (var dte in solutions)
            {
                var projCount = dte.Solution.Projects.Count;
                for (var indx = 0; indx < projCount; indx++)
                {
                    try
                    {
                        dte.Solution.Item(indx).DTE.ContextAttributes.Refresh();
                    } catch (IndexOutOfRangeException) { }
                }
            }

            result = true;
        }

        return result;
    }
}
