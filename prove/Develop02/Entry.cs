using System;

public class Entry
{
    private DateTime _date;
    private string _promptText;
    private string _entryText;

    public Entry(DateTime date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine("Date: " + _date.ToString("MM/dd/yyyy"));
        Console.WriteLine("Prompt: " + _promptText);
        Console.WriteLine("Entry: " + _entryText);
    }

    public override string ToString()
    {
        return _date.ToString("MM/dd/yyyy") + "|" + _promptText + "|" + _entryText;
    }

    public static Entry FromString(string line)
    {
        string[] parts = line.Split('|');
        DateTime date = DateTime.Parse(parts[0]);
        string promptText = parts[1];
        string entryText = parts[2];
        return new Entry(date, promptText, entryText);
    }

    public string ToCSVString()
    {
        string formattedPromptText = _promptText;
        if (_promptText.Contains(",") || _promptText.Contains("\""))
        {
            formattedPromptText = "\"" + _promptText.Replace("\"", "\"\"") + "\"";
        }

        string formattedEntryText = _entryText;
        if (_entryText.Contains(",") || _entryText.Contains("\""))
        {
            formattedEntryText = "\"" + _entryText.Replace("\"", "\"\"") + "\"";
        }

        return $"{_date:MM/dd/yyyy},{formattedPromptText},{formattedEntryText}";
    }

    public static Entry FromCSVString(string csvLine)
    {
        List<string> parts = new List<string>();
        bool inQuotes = false;
        string currentPart = string.Empty;

        // Parse csvLine and take care of comma inside quotes
        for (int i = 0; i < csvLine.Length; i++)
        {
            char c = csvLine[i];

            if (c == '\"')
            {
                inQuotes = !inQuotes;
            }
            else if (c == ',' && !inQuotes)
            {
                parts.Add(currentPart);
                currentPart = string.Empty;
            }
            else
            {
                currentPart += c;
            }
        }

        parts.Add(currentPart); // Add the last part

        DateTime date = DateTime.Parse(parts[0]);

        string promptText = parts[1];
        if (promptText.StartsWith("\"") && promptText.EndsWith("\""))
        {
            promptText = promptText.Substring(1, promptText.Length - 2).Replace("\"\"", "\"");
        }

        string entryText = parts[2];
        if (entryText.StartsWith("\"") && entryText.EndsWith("\""))
        {
            entryText = entryText.Substring(1, entryText.Length - 2).Replace("\"\"", "\"");
        }

        return new Entry(date, promptText, entryText);
    }
}