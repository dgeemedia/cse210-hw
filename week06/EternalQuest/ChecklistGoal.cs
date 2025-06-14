using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent(GoalManager manager)
    {
        _amountCompleted++;
        manager.AddPoints(_points);

        if (_amountCompleted == _target)
        {
            manager.AddPoints(_bonus);
            Console.WriteLine($"🏁 Goal completed! You earned a bonus of {_bonus} points!");
        }
        else
        {
            Console.WriteLine($"🔁 Progressed: {_amountCompleted}/{_target}. You earned {_points} points.");
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        return $"[{(_amountCompleted >= _target ? "X" : " ")}] {_shortName} ({_description}) -- Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }
}
