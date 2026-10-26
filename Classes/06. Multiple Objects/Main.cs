namespace ObjectOriented.Classes.MultipleObjects;

public static class Exercise
{
    public static void Run()
    {
        var aragorn = new Brawler("Aragorn", 4, 4);
        var gimli = new Brawler("Gimli", 2, 7);
        var legolas = new Brawler("Legolas", 7, 7);
        var frodo = new Brawler("Frodo", 3, 2);

        Fight(aragorn, gimli);
        Fight(legolas, frodo);
    }

    // don't touch below this line

    public static void Fight(Brawler f1, Brawler f2)
    {
        Console.WriteLine($"{f1.Name}: {f1.Power} power");
        Console.WriteLine($"{f2.Name}: {f2.Power} power");
        if (f1.Power > f2.Power)
        {
            Console.WriteLine($"{f1.Name} wins!");
        }
        else if (f1.Power < f2.Power)
        {
            Console.WriteLine($"{f2.Name} wins!");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }
        Console.WriteLine("---------------------------------");
    }
}

public class Brawler
{
    public string Name { get; set; }
    public int Speed { get; set; }
    public int Strength { get; set; }
    public int Power { get; set; }

    public Brawler(string name, int speed, int strength)
    {
        Name = name;
        Speed = speed;
        Strength = strength;
        Power = speed * strength;
    }
}
