using System;

public static class PromptGenerator
{
    private static List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I could do one thing over today, what would it be?"
        // ← you can add more here
    };

    private static Random _random = new Random();

    public static string GetRandomPrompt()
    {
        int idx = _random.Next(_prompts.Count);
        return _prompts[idx];
    }
}
