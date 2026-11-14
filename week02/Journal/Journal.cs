using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private string[] _prompts =
    {
        "What was the best part of your day?",
        "What is something new you learned recently?",
        "Who made a positive difference in your life today?",
        "What is one goal you want to work toward?",
        "Describe a moment when you felt proud of yourself.",
        "What is something you are grateful for right now?"
    };
    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Length)];
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("There are no entries yet.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(fileName, json);
    }

    public void LoadFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("No saved journal file was found. The current journal was left unchanged.");
            return;
        }

        string json = File.ReadAllText(fileName);
        List<Entry> loadedEntries = JsonSerializer.Deserialize<List<Entry>>(json);
        if (loadedEntries == null)
        {
            Console.WriteLine("The journal file was empty or invalid. The current journal was left unchanged.");
            return;
        }

        // Replacing the list avoids duplicating entries when the journal is loaded.
        _entries = loadedEntries;
    }
}
