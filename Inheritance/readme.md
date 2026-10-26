# Inheritance

We've made it to the holy grail of object-oriented programming: [inheritance](<https://en.wikipedia.org/wiki/Inheritance_(object-oriented_programming)>).

Non-OOP languages like [Go](https://go.dev/) and [Rust](https://www.rust-lang.org/) support encapsulation and abstraction... almost *every* language does. Inheritance, on the other hand, is typically unique to class-based languages like C#, Java, and Ruby.

## What Is Inheritance?

Inheritance allows a "child" class, to *inherit* properties and methods from a "parent" class. It's a way to share code between classes. For example, say we have this `Aircraft` class:

```csharp
public class Aircraft
{
    public int Height { get; set; }
    public int Speed { get; set; }

    public Aircraft(int height, int speed)
    {
        Height = height;
        Speed = speed;
    }

    public void FlyUp()
    {
        Height += Speed;
    }
}
```

And say we want to also model more specific *kinds* of aircraft. We could create a more specific `Helicopter` class like this:

```csharp
public class Helicopter
{
    public int Height { get; set; }
    public int Speed { get; set; }
    public int Direction { get; set; }

    public Helicopter(int height, int speed)
    {
        Height = height;
        Speed = speed;
        Direction = 0;
    }

    public void FlyUp()
    {
        Height += Speed;
    }

    public void Rotate()
    {
        Direction += 90;
    }
}
```

Trouble is, we've rewritten a lot of the same code twice... wouldn't it be nice if a `Helicopter` could just take all the behavior from an `Aircraft`, and then just add its own unique behavior on top of that? Well, it can! We'll just make `Helicopter` a child class of `Aircraft`:

```csharp
public class Helicopter : Aircraft
{
    public int Direction { get; set; }

    public Helicopter(int height, int speed) : base(height, speed)
    {
        Direction = 0;
    }

    public void Rotate()
    {
        Direction += 90;
    }
}
```

By adding `: Aircraft` after `Helicopter`, we're saying "make `Helicopter` a child class of `Aircraft`". Now `Helicopter` inherits all the properties and methods of `Aircraft`!

The [base](https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/base) keyword refers to the parent class, meaning we can use it to call the parent class's constructor and other methods. So the `Helicopter`'s constructor says "first, call the `Aircraft` constructor, and then additionally set the `Direction` property".

Now, say we want to create a `Jet` class. Again, because all jets are aircraft, we can inherit from `Aircraft` again. One parent class can have as many child classes as you want.

```csharp
public class Jet : Aircraft
{
    // Jets always start on the ground
    public Jet(int speed) : base(0, speed)
    {
    }

    public void GoSupersonic()
    {
        Speed *= 2;
    }
}
```

## Assignment

In Age of Dragons, all the archers are humans, but not all humans are necessarily archers. All humans have a `name`, but only archers have a `_numArrows` field.

Complete the `Archer` class. It should inherit the `Human` class.

1. [ ] Its constructor should:
   - Call the parent constructor
   - Set the *private* `_numArrows` field based on the constructor parameter
2. [ ] Its `GetNumArrows()` method should return the number of arrows the archer has.
