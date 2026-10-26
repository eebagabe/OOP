namespace ObjectOriented.Inheritance.AddingAWizard;

public class Hero
{
    private string _name;
    private int _health;

    public Hero(string name, int health)
    {
        _name = name;
        _health = health;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetHealth()
    {
        return _health;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
    }
}

public class Archer : Hero
{
    private int _numArrows;

    public Archer(string name, int health, int numArrows) : base(name, health)
    {
        _numArrows = numArrows;
    }

    public void Shoot(Hero target)
    {
        if (_numArrows <= 0)
        {
            throw new Exception("not enough arrows");
        }
        _numArrows -= 1;
        target.TakeDamage(10);
    }
}

public class Wizard : Hero
{
    private int _mana;

    public Wizard(string name, int health, int mana) : base(name, health)
    {
        _mana = mana;
    }

    public void Cast(Hero target)
    {
        if (_mana < 25)
        {
            throw new Exception("not enough mana");
        }

        _mana -= 25;
        target.TakeDamage(25);
    }
}
