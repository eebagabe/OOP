While inheritance is the most *unique* trait of object-oriented languages, polymorphism is probably the most powerful. It also is *not* particularly unique to class-based languages. Polymorphism is the ability of a variable, function or object to take on multiple forms.

- "poly" = "many"
- "morph" = "form"

For example, classes in the same hierarchical tree may have methods with the *same name and [signature](https://developer.mozilla.org/en-US/docs/Glossary/Signature/Function)* but different implementations. Here's a simple example:

```csharp
public class Creature
{
    public virtual void Move()
    {
        Console.WriteLine("the creature moves");
    }
}

public class Dragon : Creature
{
    public override void Move()
    {
        Console.WriteLine("the dragon flies");
    }
}

public class Kraken : Creature
{
    public override void Move()
    {
        Console.WriteLine("the kraken swims");
    }
}

foreach (var creature in new Creature[] { new Creature(), new Dragon(), new Kraken() })
{
    creature.Move();
}
// prints:
// the creature moves
// the dragon flies
// the kraken swims
```

Because all three classes have a `Move()` method, we can shove the objects into a single array of `Creature`, and call the same method on each of them, even though the *implementation* (method body) is different.

In C# the parent marks the method as [`virtual`](https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/virtual) and each child replaces it with [`override`](https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/override). If it has a `Move()` method inherited from `Creature`, we can treat it like a `Creature`.

## Assignment

Let's build some [hit-box](https://www.makeuseof.com/hitboxes-gaming/) logic for our game, starting with a simple `Rectangle`.

Complete the constructor. Configure the class to have properties matching the variables passed into the constructor in this order:

1. `X1`
2. `Y1`
3. `X2`
4. `Y2`
