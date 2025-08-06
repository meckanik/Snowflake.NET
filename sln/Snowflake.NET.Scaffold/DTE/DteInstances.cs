using System.Runtime.InteropServices;
using Microsoft.VisualStudio.OLE.Interop;

namespace Snowflake.NET.Scaffold.DTE;

/// <summary>
///     Contains methods for Visual Studio automation.
/// </summary>
public static class DteInstances
{
    /// <summary>
    ///     Returns a collection of running instances of VisualStudio.
    /// </summary>
    /// <returns>A collection of DTE objects.</returns>
    public static IEnumerable<EnvDTE.DTE> GetInstances()
    {
        int retVal = GetRunningObjectTable(0, out IRunningObjectTable rot);

        if (retVal == 0)
        {
            rot.EnumRunning(out IEnumMoniker enumMoniker);

            //uint fetched = uint.MinValue;
            IMoniker[] moniker = new IMoniker[1];
            while (enumMoniker.Next(1, moniker, out var fetched) == 0)
            {
                CreateBindCtx(0, out IBindCtx bindCtx);
                string displayName;
                moniker[0].GetDisplayName(bindCtx, null, out displayName);
                bool isVisualStudio = displayName.StartsWith("!VisualStudio", StringComparison.OrdinalIgnoreCase);
                if (isVisualStudio)
                {
                    rot.GetObject(moniker[0], out var obj);
                    var dte = obj as EnvDTE.DTE;
                    yield return dte!;
                }
            }
        }
    }

    [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
    [DllImport("ole32.dll")]
    private static extern void CreateBindCtx(int reserved, out IBindCtx ppbc);

    [DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
    [DllImport("ole32.dll")]
    private static extern int GetRunningObjectTable(int reserved, out IRunningObjectTable prot);
}
