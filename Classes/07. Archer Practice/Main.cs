namespace ObjectOriented.Classes.ArcherPractice;

public class Archer
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int NumArrows { get; set; }

    public Archer(string name, int health, int numArrows)
    {
        Name = name;
        Health = health;
        NumArrows = numArrows;
    }

    public void TakeHit()
    {
        if (Health == 0)
        {
            throw new Exception($"{Name} is dead");
        }

        Health -= 1;
    }

    public void Shoot(Archer target)
    {
        if (Health == 0)
        {
            throw new Exception($"{Name} is dead");
        }

        if (NumArrows == 0)
        {
            throw new Exception($"{Name} can't shoot");
        }

        NumArrows -= 1;
        Console.WriteLine($"{Name} shoots {target.Name}");
        target.TakeHit();
    }

    // don't touch below this line

    public (string Name, int Health, int NumArrows) GetStatus()
    {
        return (Name, Health, NumArrows);
    }

    public void PrintStatus()
    {
        Console.WriteLine($"{Name} has {Health} health and {NumArrows} arrows");
    }
}
