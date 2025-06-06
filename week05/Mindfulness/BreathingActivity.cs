using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();
        int cycleTime = 6; // 3 seconds in, 3 seconds out

        for (int i = 0; i < duration; i += cycleTime)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(3);
            Console.Write("Breathe out... ");
            ShowCountdown(3);
        }

        DisplayEndingMessage();
    }
}
