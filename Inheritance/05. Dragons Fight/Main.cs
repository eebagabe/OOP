namespace ObjectOriented.Inheritance.DragonsFight;

public static class Exercise
{
    public static void Run()
    {
        var dragons = new List<Dragon>
        {
            new("Green Dragon", 0, 0, 1),
            new("Red Dragon", 2, 2, 2),
            new("Blue Dragon", 4, 3, 3),
            new("Black Dragon", 5, -1, 4),
        };

        foreach (var dragon in dragons)
        {
            Describe(dragon);
        }

        for (var index = 0; index < dragons.Count; index++)
        {
            var units = new List<Unit>(dragons);
            units.RemoveAt(index);

            dragons[index].BreatheFire(3, 3, units);
        }
    }

    public static void Describe(Dragon dragon)
    {
        Console.WriteLine($"{dragon.Name} is at {dragon.PosX}/{dragon.PosY}");
    }
}

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
        return PosX >= x1
            && PosX <= x2
            && PosY >= y1
            && PosY <= y2;
    }
}

public class Dragon : Unit
{
    private int _fireRange;

    public Dragon(string name, int posX, int posY, int fireRange) : base(name, posX, posY)
    {
        _fireRange = fireRange;
    }

    public void BreatheFire(int x, int y, List<Unit> units)
    {
        Console.WriteLine("====================================");
        Console.WriteLine($"{Name} breathes fire at {x}/{y} with range {_fireRange}");
        Console.WriteLine("------------------------------------");
        foreach (var unit in units)
        {
            var inArea = unit.InArea(
                x - _fireRange,
                y - _fireRange,
                x + _fireRange,
                y + _fireRange);
            if (inArea)
            {
                Console.WriteLine($"{unit.Name} is hit by the fire");
            }
        }
    }
}
