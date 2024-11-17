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
}