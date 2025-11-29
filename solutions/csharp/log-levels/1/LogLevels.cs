static class LogLine
{
    public static string Message(string logLine)
    {
        string toRemove = "]: ";
        int MessageStartIndex = logLine.IndexOf(toRemove);
        logLine = logLine.Remove(0, MessageStartIndex + toRemove.Length);
        logLine = logLine.Replace("\r", "").Replace("\n", "").Replace("\t", "");
        while (logLine.EndsWith(" "))
        {
            logLine = logLine.Remove(logLine.Length - 1);     
        }

        while (logLine.StartsWith(" "))
        {
            logLine = logLine.Remove(0, 1);     
        }
        return logLine;
    }

    public static string LogLevel(string logLine)
    {
        int startIndex = logLine.IndexOf("[") + 1;
        int endIndex = logLine.IndexOf("]") - 1;
        return logLine.Substring(startIndex, endIndex).ToLower();
    }

    public static string Reformat(string logLine)
    {
        return String.Format("{0} ({1})", Message(logLine), LogLevel(logLine));
    }
}
