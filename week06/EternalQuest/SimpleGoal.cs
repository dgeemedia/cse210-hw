using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent(GoalManager manager)
    {
        if (!_isComplete)
        {
            manager.AddPoints(_points);
            _isComplete = true;
            Console.WriteLine("🎉 Goal completed! You earned " + _points + " points!");
        }
        else
        {
            Console.WriteLine("✅ Goal already completed.");
        }
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}
