using System.Text;
using Snowflake.NET.Helpers;

namespace Snowflake.NET.Scaffold.Scaffolding;

internal class Writer
{
    private const string ttab = "\t\t";

    private readonly string _codeSheetPath;
    private readonly string _codeSheetName;
    private readonly StringBuilder _writer;

    internal Writer(string path, string filename)
    {
        _codeSheetPath = path;
        _codeSheetName = filename;
        _writer = new StringBuilder();
    }

    internal void Write(string value, bool noLineEnding = false)
    {
        if (noLineEnding)
        {
            _writer.Append(value);
        }
        else
        {
            _writer.AppendLine(value);
        }
    }

    internal void WriteOpenBracket(bool tabbed = true)
    {
        var tab = tabbed ? "\t" : string.Empty;
        _writer.AppendLine(tab + "{");
    }

    internal void WriteCloseBracket(bool tabbed = true)
    {
        var tab = tabbed ? "\t" : string.Empty;
        _writer.AppendLine(tab + "}");
    }

    internal void Wrap(string value, bool tabbed = true, bool trailingCrLf = false)
    {
        var tab = tabbed ? "\t" : string.Empty;
        _writer.AppendLine(tab + "{");
        _writer.AppendLine($"{tab}\t{value}");

        var crlf = trailingCrLf ? "\r\n" : string.Empty;
        _writer.AppendLine(tab + "}" + crlf);
    }

    internal void Wrap(IEnumerable<string> values, bool tabbed = true, bool terminate = false)
    {
        var tab = tabbed ? "\t" : string.Empty;
        _writer.AppendLine(tab + "{");
        foreach (string value in values)
        {
            _writer.AppendLine($"{tab}\t{value}");
        }

        var term = terminate ? ";\r\n" : string.Empty;
        _writer.AppendLine(tab + "}" + term);
    }

    internal void WriteSummary(string value, bool tabbed = true)
    {
        var tab = tabbed ? "\t" : string.Empty;

        _writer.AppendLine($"{tab}/// <summary>");
        _writer.AppendLine($"{tab}///{ttab}{value}");
        _writer.AppendLine($"{tab}/// </summary>");
    }

    internal void WriteUsings(string[] usings)
    {
        foreach (var val in usings)
        {
            _writer.AppendLine(val);
        }
    }

    internal void WriteToFile()
    {
        
        var tmp = new StringBuilder(TextHelpers.RemoveTrailingCrLf(_writer.ToString()));
        tmp.AppendLine("}");

        if (!Directory.Exists(_codeSheetPath))
        {
            Directory.CreateDirectory(_codeSheetPath);
        }

        File.WriteAllText(Path.Combine(_codeSheetPath, $"{_codeSheetName}.cs"), tmp.ToString(), Encoding.UTF8);
    }
}
