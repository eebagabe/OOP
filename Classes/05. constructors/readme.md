It's rare in the real world to see a class that defines properties like this (as we did):

```csharp
public class Soldier
{
    public string Name { get; set; } = "Legolas";
    public int Armor { get; set; } = 2;
    public int NumWeapons { get; set; } = 2;
}
```

A [constructor](https://learn.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/constructors) is (usually) better. It's a special method with the same name as the class that is called automatically when you create a new instance of a class with `new`.

So, using a constructor, the code from above would look like this:

```csharp
public class Soldier
{
    public string Name { get; set; }
    public int Armor { get; set; }
    public int NumWeapons { get; set; }

    public Soldier()
    {
        Name = "Legolas";
        Armor = 2;
        NumWeapons = 2;
    }
}
```

Not only is this *safer* (we'll talk about why later), but it also allows us to make the starting property values configurable:

```csharp
public class Soldier
{
    public string Name { get; set; }
    public int Armor { get; set; }
    public int NumWeapons { get; set; }

    public Soldier(string name, int armor, int numWeapons)
    {
        Name = name;
        Armor = armor;
        NumWeapons = numWeapons;
    }
}

var soldierOne = new Soldier("Legolas", 2, 10);
Console.WriteLine(soldierOne.Name);
// prints "Legolas"
Console.WriteLine(soldierOne.Armor);
// prints "2"
Console.WriteLine(soldierOne.NumWeapons);
// prints "10"

var soldierTwo = new Soldier("Gimli", 5, 1);
Console.WriteLine(soldierTwo.Name);
// prints "Gimli"
Console.WriteLine(soldierTwo.Armor);
// prints "5"
Console.WriteLine(soldierTwo.NumWeapons);
// prints "1"
```

## Assignment

**Add a constructor to the `Wall` class**.

1. [ ] It should take `depth`, `height` and `width` as parameters, in that order, and set them as instance properties.
2. [ ] Compute an additional property called `Volume`. Volume is the depth times height times width
