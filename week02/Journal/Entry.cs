using System;

public class Entry
{
    // Member variables
    public string _date;
    public string _prompt;
    public string _response;

    // Constructor
    public Entry(string date, string prompt, string response)
    {
        _date     = date;
        _prompt   = prompt;
        _response = response;
    }

    // Display this entry to the console
    public void Display()
    {
        Console.WriteLine($"{_date} — {_prompt}");
        Console.WriteLine($"> {_response}");
        Console.WriteLine();
    }

    // Format this entry as a single line for saving
    // using '|' as a separator
    public string ToFileString()
    {
        // Escape any '|' in the response
        var safeResponse = _response.Replace("|", "/");
        return $"{_date}|{_prompt}|{safeResponse}";
    }

    // Static helper to parse a line from file back into an Entry
    public static Entry FromFileString(string line)
    {
        var parts = line.Split('|');
        if (parts.Length < 3) return null;
        
        // date = parts[0], prompt = parts[1], response = parts[2]
        return new Entry(parts[0], parts[1], parts[2]);
    }
}
