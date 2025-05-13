using System;

class Program
{
    static void Main(string[] args)
{
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";
        string sign = "";

        // Determine letter grade
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine sign
        int lastDigit = percent % 10;

        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && percent < 93) // A- only for 90-92
        {
            sign = "-";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Pass/fail message
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed.");
        }
        else
        {
            Console.WriteLine("Oops! Better luck next time!");
        }
    }
}