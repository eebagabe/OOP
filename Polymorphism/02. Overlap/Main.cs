namespace ObjectOriented.Polymorphism.Overlap;

public class Rectangle
{
    public bool Overlaps(Rectangle rect)
    {
        var selfMinorX = GetLeftX();
        var selfMajorX = GetRightX();

        var selfMajorY = GetTopY();
        var selfMinorY = GetBottomY();

        var rectMinorX = rect.GetLeftX();
        var rectMajorX = rect.GetRightX();

        var rectMajorY = rect.GetTopY();
        var rectMinorY = rect.GetBottomY();

        if (selfMinorX > rectMajorX || selfMajorX < rectMinorX || selfMinorY > rectMajorY || selfMajorY < rectMinorY)
        {
            return false;
        }

        return true;
    }

    // don't touch below this line

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
        if (_x1 < _x2)
        {
            return _x1;
        }
        return _x2;
    }

    public int GetRightX()
    {
        if (_x1 > _x2)
        {
            return _x1;
        }
        return _x2;
    }

    public int GetTopY()
    {
        if (_y1 > _y2)
        {
            return _y1;
        }
        return _y2;
    }

    public int GetBottomY()
    {
        if (_y1 < _y2)
        {
            return _y1;
        }
        return _y2;
    }

    public override string ToString()
    {
        return $"Rectangle({_x1}, {_y1}, {_x2}, {_y2})";
    }
}
