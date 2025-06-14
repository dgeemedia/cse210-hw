public class LevelSystem
{
    public static int CalculateLevel(int score)
    {
        return score / 100;
    }

    public static void DisplayLevel(int score)
    {
        int level = CalculateLevel(score);
        Console.WriteLine($"🎮 Current Level: {level}");
    }
}
