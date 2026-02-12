using System;
public class Square : Shape
{
    private float _side;
    public Square (string color, float side) : base(color) => _side = side;
    public float GetSide() => _side;
    public void SetSide(float side) => _side = side;
    public override double GetArea() => _side * _side;
}