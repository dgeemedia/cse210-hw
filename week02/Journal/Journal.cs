using System;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    // Add a brand–new entry
    public void AddEntry(Entry e)
    {
        _entries.Add(e);
    }

    // Display every entry
    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine("Your Journal Entries:");
        Console.WriteLine("---------------------");
        foreach (var e in _entries)
        {
            e.Display();
        }
    }

    // Save to a file (overwrites if it exists)
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var e in _entries)
            {
                outputFile.WriteLine(e.ToFileString());
            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }

    // Load from a file (replaces current entries)
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"File not found: {filename}");
            return;
        }

        _entries.Clear();
        var lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            var e = Entry.FromFileString(line);
            if (e != null)
                _entries.Add(e);
        }
        Console.WriteLine($"Journal loaded from {filename}");
    }
}
