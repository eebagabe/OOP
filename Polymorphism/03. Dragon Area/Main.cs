namespace ObjectOriented.Polymorphism.DragonArea;

public class Unit
{
    public string Name { get; set; }
    public double PosX { get; set; }
    public double PosY { get; set; }

    public Unit(string name, double posX, double posY)
    {
        Name = name;
        PosX = posX;
        PosY = posY;
    }

    public virtual bool InArea(double x1, double y1, double x2, double y2)
    {
        return PosX >= x1
            && PosX <= x2
            && PosY >= y1
            && PosY <= y2;
    }
}

public class Dragon : Unit
{
    private Rectangle _hitBox;

    public double Height { get; set; }
    public double Width { get; set; }
    public double FireRange { get; set; }

    public Dragon(string name, double posX, double posY, double height, double width, double fireRange) : base(name, posX, posY)
    {
        Height = height;
        Width = width;
        FireRange = fireRange;

        var x1 = posX - width / 2;
        var y1 = posY - height / 2;
        var x2 = posX + width / 2;
        var y2 = posY + height / 2;
        _hitBox = new Rectangle(x1, y1, x2, y2);
    }

    public override bool InArea(double x1, double y1, double x2, double y2)
    {
        var areaRect = new Rectangle(x1, y1, x2, y2);
        return _hitBox.Overlaps(areaRect);
    }
}

public class Rectangle
{
    public bool Overlaps(Rectangle rect)
    {
        return GetLeftX() <= rect.GetRightX()
            && GetRightX() >= rect.GetLeftX()
            && GetTopY() >= rect.GetBottomY()
            && GetBottomY() <= rect.GetTopY();
    }

    private double _x1;
    private double _y1;
    private double _x2;
    private double _y2;

    public Rectangle(double x1, double y1, double x2, double y2)
    {
        _x1 = x1;
        _y1 = y1;
        _x2 = x2;
        _y2 = y2;
    }

    public double GetLeftX()
    {
        if (_x1 < _x2)
        {
            return _x1;
        }
        return _x2;
    }

    public double GetRightX()
    {
        if (_x1 > _x2)
        {
            return _x1;
        }
        return _x2;
    }

    public double GetTopY()
    {
        if (_y1 > _y2)
        {
            return _y1;
        }
        return _y2;
    }

    public double GetBottomY()
    {
        if (_y1 < _y2)
        {
            return _y1;
        }
        return _y2;
    }
}
