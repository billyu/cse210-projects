using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void CreateNewEntry()
    {
        // variables
        PromptGenerator promptGenerator = new PromptGenerator();
        DateTime date = DateTime.Now;
        string promptText = promptGenerator.GetRandomPrompt();
        string entryText = "";

        // Get the user's response
        Console.WriteLine(promptText);
        Console.Write("> ");
        entryText = Console.ReadLine();
                
        // Create a new entry
        Entry newEntry = new Entry(date, promptText, entryText);
        AddEntry(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }

    public void LoadFromFile(string file)
    {
        using (StreamReader reader = new StreamReader(file))
        {
            _entries.Clear();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Entry entry = Entry.FromString(line);
                _entries.Add(entry);
            }
        }
    }
}