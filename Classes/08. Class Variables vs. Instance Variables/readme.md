# Class Variables vs. Instance Variables

We've already worked with both class variables and instance variables, but we haven't really talked about the difference.

## Instance Variables

Instance variables vary from object to object and are **declared without the `static` keyword**, usually set in the constructor. They're more common:

```csharp
public class Wall
{
    public int Height { get; set; }

    public Wall()
    {
        Height = 10;
    }
}

var southWall = new Wall();
southWall.Height = 20; // only updates this instance of a wall
Console.WriteLine(southWall.Height);
// prints "20"

var northWall = new Wall();
Console.WriteLine(northWall.Height);
// prints "10"
```

## Class Variables

Class variables are shared between instances of the same class and are **declared with the [`static`](https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/static) keyword**. They're less common:

```csharp
public class Wall
{
    public static int Height { get; set; } = 10;
}

Console.WriteLine(Wall.Height);
// prints "10"

Wall.Height = 20; // updates it for every Wall

Console.WriteLine(Wall.Height);
// prints "20"
```

In C# (and many other languages) these are called [static members](https://learn.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members).

## Which Should I Use?

Generally speaking, *stay away from class variables*. Just like global variables, class variables are usually a bad idea because they make it hard to keep track of which parts of your program are making updates. However, it is important to understand how they work because you may see them in the wild.

## Assignment

Some lazy class variable code written by another dev team at Age of Dragons Studios is causing bugs in our team's `Dragon` class.

In the `Run()` method (that our team isn't responsible for) the line:

```csharp
Dragon.Element = "fire";
```

should *not* affect our existing `Dragon` instances! The `Dragon` class should be safe to use in other parts of the codebase, even if silly developers are out there changing class-level variables.

**Fix the `Dragon` class**.

1. [ ] Remove the `static` `Element` *class* variable.
2. [ ] Use an *instance* property for `Element`, and allow it to be set in the constructor.

Once `Element` is an instance property, `Dragon.Element = "fire"` doesn't even compile anymore. Run it with `dotnet run -- class-variables`.
