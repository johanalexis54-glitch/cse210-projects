using System;
public class Circle : Shape
{
    private float _radius;
    public Circle (string color, float radius): base(color) => _radius = radius;
    public float GetRadius() => _radius;
    public void SetRadius(float radius) => _radius = radius;
    public override double GetArea() => Math.PI * _radius * _radius;
}