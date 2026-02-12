using System;
public class Rectangle : Shape
{
    private float _length;
    private float _width;

    public Rectangle (string color, float length, float width): base(color)
    {
        _length = length;
        _width = width;

    }
    public float GetLength() => _length;
    public void SetLength(float length) => _length = length;
    public float GetWidth() => _width;
    public void SetWidth(float width) => _width = width;
    public override double GetArea() => _length * _width;
}