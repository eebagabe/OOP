namespace ObjectOriented.Inheritance.InheritancePractice;

public class Rectangle
{
    private int _length;
    private int _width;

    public Rectangle(int length, int width)
    {
        _length = length;
        _width = width;
    }

    public int GetArea()
    {
        return _length * _width;
    }

    public int GetPerimeter()
    {
        return 2 * (_length + _width);
    }
}

public class Square : Rectangle
{
    public Square(int length) : base(length, length)
    {
    }
}
