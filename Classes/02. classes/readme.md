# Classes

A [class](https://learn.microsoft.com/dotnet/csharp/fundamentals/types/classes) is a special type in an object-oriented programming language like C#. If you squint really hard, it's kinda like a dictionary in that it usually stores named value pairs:

```csharp
// Defines a new class called "Soldier"
// with three properties: Health, Armor, Damage
public class Soldier
{
    public int Health { get; set; } = 5;
    public int Armor { get; set; } = 3;
    public int Damage { get; set; } = 2;
}
```

Just like a string, int or double, a class is a *type*, but instead of being a built-in type, classes are custom types that you define.

## Objects

So if a class is a new custom type, what's an object? Objects are just [instance](https://stackoverflow.com/questions/20461907/what-is-meaning-of-instance-in-programming)s of a class.

Yeah I know, "instance" is another fancy programming word. It just means "an example of" or "a specific case of". For example, "Lane is an instance of a human" or "My Chemical Romance is an instance of a band".

For example:

```csharp
var health = 50;
// health is an instance of an int type
var aragorn = new Soldier();
// aragorn is an instance of the Soldier class type
```

Each new instance of a class is an "object".

## Example

```csharp
public class Archer
{
    public int Health { get; set; } = 40;
    public int Arrows { get; set; } = 10;
}

// Create several instances of the Archer class
var legolas = new Archer();
var bard = new Archer();

// Print class properties
Console.WriteLine(legolas.Health); // 40
Console.WriteLine(bard.Arrows); // 10
```

## Assignment

1. [ ] Create a class called `Wall`. It should have:
   1. [ ] A property called `Armor` initialized to (initially set to) `10`
   2. [ ] A property called `Height` initialized to `5`
2. [ ] Create a class called `BatteringRam`. It should have:
   1. [ ] A property called `Damage` initialized to `2`
   2. [ ] A property called `Length` initialized to `4`
