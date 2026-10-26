namespace ObjectOriented.Inheritance.InheritanceHierarchy;

public class Human
{
    private string _name;

    public Human(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }
}

public class Archer : Human
{
    private int _numArrows;

    public Archer(string name, int numArrows) : base(name)
    {
        _numArrows = numArrows;
    }

    public int GetNumArrows()
    {
        return _numArrows;
    }

    public void UseArrows(int num)
    {
        if (_numArrows < num)
        {
            throw new Exception("not enough arrows");
        }

        _numArrows -= num;
    }
}

public class Crossbowman : Archer
{
    public Crossbowman(string name, int numArrows) : base(name, numArrows)
    {
    }

    public string TripleShot(Human target)
    {
        UseArrows(3);

        return $"{target.GetName()} was shot by 3 crossbow bolts";
    }
}
