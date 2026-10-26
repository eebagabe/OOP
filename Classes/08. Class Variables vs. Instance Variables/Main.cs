namespace ObjectOriented.Classes.ClassVariablesVsInstanceVariables;

public class Dragon
{
    public string Element { get; set; }

    public Dragon(string element)
    {
        Element = element;
    }

    public int GetBreathDamage()
    {
        if (Element == "fire")
        {
            return 300;
        }
        if (Element == "ice")
        {
            return 150;
        }
        return 0;
    }
}

// don't touch below this line

public static class Exercise
{
    public static void Run()
    {
        var firstDragon = new Dragon("fire");
        Console.WriteLine($"{firstDragon.Element} dragon does {firstDragon.GetBreathDamage()} damage");

        var secondDragon = new Dragon("ice");
        // Dragon.Element = "fire"; no longer compiles: Element belongs to each instance, not to the class
        Console.WriteLine($"{secondDragon.Element} dragon does {secondDragon.GetBreathDamage()} damage");
    }
}
