# Methods

So you might be wondering *why* classes are useful, they're like [dictionaries](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary-2)... but worse... Right?

Well, no. First of all, classes provide structure. The `class` definition says "hey, I have these specific properties". A dictionary is more powerful in the sense that you can store whatever you want in it, but that also makes it less clear *what on earth is in there* at any given time.

*Another* thing that makes classes useful is that they can have [methods](https://learn.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/methods)! A method is just a function that's tied directly to a class and has access to its properties. See the `TakeDamage` method here:

```csharp
public class Soldier
{
    public int Health { get; set; } = 5;

    // This is a method that reduces the
    // health of the soldier
    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
}

var soldierOne = new Soldier();
soldierOne.TakeDamage(2);
Console.WriteLine(soldierOne.Health);
// prints "3"

var soldierTwo = new Soldier();
soldierTwo.TakeDamage(1);
Console.WriteLine(soldierTwo.Health);
// prints "4"
```

## This

Methods are defined *within* the `class` declaration. They always run on the instance of the class that the method is being called on. That instance is available through the [`this`](https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/this) keyword, and because `this` is a reference to the object, you can use it to read and update the properties of the object. In C# `this` is implicit, so `Health -= damage` is the same as `this.Health -= damage`.

Notice that methods are called directly on an object instance using the dot operator:

```csharp
myObject.MyMethod();
```

## Assignment

**Complete the `Fortify()` method on the wall class**. It should double the current `Armor` property.
