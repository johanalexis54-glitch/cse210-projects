using System;
public class EternalGoal : Goal
{
    public EternalGoal (string name, string description, int points) : base(name, description, points){}
    public override void RecordEvent()
    {
        Console.WriteLine($"¡Congratulations! You win{_points} puntos.");
    }
    public override bool IsComplete() => false;
    public override string GetStringRepresentation() => $"EternalGoal: {_shortName}, {_description}, {_points}";


}