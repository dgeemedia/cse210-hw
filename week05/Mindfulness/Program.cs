using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. View Activity Log");
            Console.WriteLine("5. Quit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            Activity activity;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    activity.DisplayStartingMessage();
                    ((BreathingActivity)activity).Run();
                    activity.DisplayEndingMessage();
                    break;

                case "2":
                    activity = new ReflectionActivity();
                    activity.DisplayStartingMessage();
                    ((ReflectionActivity)activity).Run();
                    activity.DisplayEndingMessage();
                    break;

                case "3":
                    activity = new ListingActivity();
                    activity.DisplayStartingMessage();
                    ((ListingActivity)activity).Run();
                    activity.DisplayEndingMessage();
                    break;

                case "4":
                    ShowActivityLog();
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }

    static void ShowActivityLog()
    {
        string filePath = "activity_log.csv";
        if (!File.Exists(filePath))
        {
            Console.WriteLine("No log file found.");
            return;
        }

        Console.Clear();
        Console.WriteLine("Log Viewer:");
        Console.WriteLine("1. View All Logs");
        Console.WriteLine("2. Filter by Date");
        Console.WriteLine("3. Filter by Activity Type");
        Console.Write("Choose an option: ");
        string option = Console.ReadLine();

        string[] lines = File.ReadAllLines(filePath);
        if (lines.Length <= 1)
        {
            Console.WriteLine("No logs available.");
            return;
        }

        IEnumerable<string> results = lines.Skip(1); // Skip header

        switch (option)
        {
            case "1":
                // No filter, show all
                break;

            case "2":
                Console.Write("Enter date (yyyy-MM-dd): ");
                string dateFilter = Console.ReadLine();
                results = results.Where(l => l.StartsWith(dateFilter));
                break;

            case "3":
                Console.WriteLine("Select activity type:");
                Console.WriteLine("1. Breathing");
                Console.WriteLine("2. Reflection");
                Console.WriteLine("3. Listing");
                Console.Write("Enter choice: ");
                string typeChoice = Console.ReadLine();
                string activityFilter = "";

                switch (typeChoice)
                {
                    case "1":
                        activityFilter = "Breathing";
                        break;
                    case "2":
                        activityFilter = "Reflection";
                        break;
                    case "3":
                        activityFilter = "Listing";
                        break;
                    default:
                        Console.WriteLine("Invalid activity type.");
                        return;
                }

                results = results.Where(l => l.Split(',')[1].Equals(activityFilter, StringComparison.OrdinalIgnoreCase));
                break;

            default:
                Console.WriteLine("Invalid log view option.");
                return;
        }

        // Display the results after filtering
        Console.WriteLine("\n--- Filtered Activity Log ---");
        Console.WriteLine("Date\t\t\tActivity\tDuration");
        foreach (var line in results)
        {
            var parts = line.Split(',');
            if (parts.Length >= 3)
            {
                Console.WriteLine($"{parts[0],-24} {parts[1],-12} {parts[2]} seconds");
            }
        }
    }
}
