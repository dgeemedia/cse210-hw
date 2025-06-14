using System;
public class Badge
{
    public static void ShowBadge(int score)
    {
        if (score >= 1000)
        {
            Console.WriteLine("🏅 You earned the Gold Achiever badge!");
        }
        else if (score >= 500)
        {
            Console.WriteLine("🥈 You earned the Silver Striver badge!");
        }
        else if (score >= 250)
        {
            Console.WriteLine("🥉 You earned the Bronze Beginner badge!");
        }
    }
}
