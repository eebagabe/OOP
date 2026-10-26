namespace ObjectOriented.Inheritance.Dragons;

public class Unit
{
    public string Name { get; set; }
    public int PosX { get; set; }
    public int PosY { get; set; }

    public Unit(string name, int posX, int posY)
    {
        Name = name;
        PosX = posX;
        PosY = posY;
    }

    public bool InArea(int x1, int y1, int x2, int y2)
    {
        // Meu X tem que ser maior que o x inicial e menor que o x final
        // Meu Y tem que ser maior que o y inicial e menor que o y final
        return x1 <= PosX && PosX <= x2 && y1 <= PosY && PosY <= y2;
    }
}

public class Dragon : Unit
{
    private int _fireRange;

    public Dragon(string name, int posX, int posY, int fireRange) : base(name, posX, posY)
    {
        _fireRange = fireRange;
    }

    public List<Unit> BreatheFire(int x, int y, List<Unit> units)
    {
        var r = _fireRange;
        var x1 = x - r;
        var x2 = x + r;
        var y1 = y - r;
        var y2 = y + r;

        var inArea = new List<Unit>();

        foreach (var unit in units)
        {
            if (unit.InArea(x1, y1, x2, y2))
            {
                inArea.Add(unit);
            }
        }

        return inArea;
    }
}
