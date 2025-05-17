using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to file");
            Console.WriteLine("4. Load the journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option (1–5): ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal);
                    break;
                case "2":
                    journal.Display();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    journal.SaveToFile(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    journal.LoadFromFile(Console.ReadLine());
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please select 1–5.");
                    break;
            }
        }
    }

    static void WriteNewEntry(Journal journal)
    {
        string prompt  = PromptGenerator.GetRandomPrompt();
        string date    = DateTime.Now.ToShortDateString();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        var entry = new Entry(date, prompt, response);
        journal.AddEntry(entry);
        Console.WriteLine("Entry recorded.");
    }
}
