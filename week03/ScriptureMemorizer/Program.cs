using System;

class Program
{
    static void Main(string[] args)
    {
        // === ENHANCEMENT: Load multiple scriptures from a file and pick one randomly ===
        List<Scripture> scriptureList = LoadScripturesFromFile("scriptures.txt");
        if (scriptureList.Count == 0)
        {
            Console.WriteLine("No scriptures found.");
            return;
        }

        Random random = new Random();
        Scripture scripture = scriptureList[random.Next(scriptureList.Count)];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // Hide 3 new words each time
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Enjoy the rest part of day!");
    }

    //Load from a file
    static List<Scripture> LoadScripturesFromFile(string filename)
    {
        var scriptures = new List<Scripture>();

        if (!File.Exists(filename))
            return scriptures;

        foreach (string line in File.ReadAllLines(filename))
        {
            if (string.IsNullOrWhiteSpace(line) || !line.Contains("|"))
                continue;

            var parts = line.Split('|');
            var referencePart = parts[0].Trim();
            var textPart = parts[1].Trim();

            string book = referencePart.Substring(0, referencePart.IndexOf(' '));
            string chapterVerse = referencePart.Substring(referencePart.IndexOf(' ') + 1);
            int chapter = int.Parse(chapterVerse.Split(':')[0]);
            var versePart = chapterVerse.Split(':')[1];

            Reference reference;
            if (versePart.Contains('-'))
            {
                int startVerse = int.Parse(versePart.Split('-')[0]);
                int endVerse = int.Parse(versePart.Split('-')[1]);
                reference = new Reference(book, chapter, startVerse, endVerse);
            }
            else
            {
                int verse = int.Parse(versePart);
                reference = new Reference(book, chapter, verse);
            }

            scriptures.Add(new Scripture(reference, textPart));
        }

        return scriptures;
    }
}