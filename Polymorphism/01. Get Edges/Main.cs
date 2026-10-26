namespace ObjectOriented.Polymorphism.GetEdges;

public class Rectangle
{
    private int _x1;
    private int _y1;
    private int _x2;
    private int _y2;

    public Rectangle(int x1, int y1, int x2, int y2)
    {
        _x1 = x1;
        _y1 = y1;
        _x2 = x2;
        _y2 = y2;
    }

    public int GetLeftX()
    {
        var x1 = _x1;
        var x2 = _x2;
        return x2 < x1 ? x2 : x1;
    }

    public int GetRightX()
    {
        var x1 = _x1;
        var x2 = _x2;

        return x1 > x2 ? x1 : x2;
    }

    public int GetTopY()
    {
        var y1 = _y1;
        var y2 = _y2;

        return y2 > y1 ? y2 : y1;
    }

    public int GetBottomY()
    {
        var y1 = _y1;
        var y2 = _y2;

        return y1 < y2 ? y1 : y2;
    }

    // don't touch below this line

    public override string ToString()
    {
        return $"Rectangle({_x1}, {_y1}, {_x2}, {_y2})";
    }
}
