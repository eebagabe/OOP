# Methods Can Return

If a normal function doesn't return anything, it's typically not a very useful function. In contrast, methods often don't return anything because they can mutate (update) the properties of the object instead. That's exactly what we did in the last assignment.

However, they *can* return values if you want! They're just functions with access to an object, after all. A common use case is a "getter" method that returns a calculated value based on the properties of the object.

```csharp
public class Soldier
{
    public int Armor { get; set; } = 2;
    public int NumWeapons { get; set; } = 2;

    public int GetSpeed()
    {
        var speed = 10;
        speed -= Armor;
        speed -= NumWeapons;
        return speed;
    }
}

var soldierOne = new Soldier();
Console.WriteLine(soldierOne.GetSpeed());
// prints "6"
```

## Assignment

Building walls in Age of Dragons can be expensive, the larger and stronger the wall, the more it costs.

**Complete the `GetCost()` method on the `Wall` class**. It should return the cost of a wall, where the cost is its **armor** multiplied by its **height**.
