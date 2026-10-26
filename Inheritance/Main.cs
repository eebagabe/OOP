namespace ObjectOriented.Inheritance;

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

// don't touch above this line

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
}
