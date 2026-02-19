using System;
using System.Runtime.CompilerServices;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public CheckListGoal(string name, string description, int points,int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted ++;
        int pointsEarner = _points;

        if (_amountCompleted >= _target)
        {
            pointsEarner += _bonus;
            Console.WriteLine($"!Congratulation¡ You complet the Goal and won a bonus of {_bonus}.");
        }
        Console.WriteLine($"!Congratilations¡ you won {pointsEarner} puntos.");
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        string statusSymbol = IsComplete() ? "[X]" : "[ ]";
        return $"{statusSymbol}{_shortName}({_description}) --Currently Completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"Check List Goal: {_shortName}, {_description}, {_points}, {_bonus}, {_target}. {_amountCompleted}";
    }
}