# Multiple Objects

Remember, *an object is an "instance" of a class*.

> In object-oriented programming, an instance is a concrete occurrence of any object... "Instance" is synonymous with "object" as they are each a particular value... "Instance" emphasizes the distinct identity of the object. The creation of an instance is called instantiation.
>
> -- [Wikipedia](<https://en.wikipedia.org/wiki/Instance_(computer_science)>)

I can create a `Wall` class (you can think of a class as a "blueprint" or a "template" for an object) like this:

```csharp
public class Wall
{
    public int Depth { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }

    public Wall(int depth, int height, int width)
    {
        Depth = depth;
        Height = height;
        Width = width;
    }
}
```

Then I can create three different "instances" of the class. Or, in other words, I can create three separate objects, each with their own properties independent of each other:

```csharp
var wallMaria = new Wall(1, 2, 3);
var wallRose = new Wall(4, 5, 6);
var wallSina = new Wall(9, 8, 7);
```

## Assignment

Take a look at the `Brawler` class and the `Fight` method provided, then **complete the `Run` method** by doing the following:

1. [ ] Create 4 new brawlers with the following stats:
   1. [ ] Name: `Aragorn`. Speed: `4`. Strength: `4`.
   2. [ ] Name: `Gimli`. Speed: `2`. Strength: `7`.
   3. [ ] Name: `Legolas`. Speed: `7`. Strength: `7`.
   4. [ ] Name: `Frodo`. Speed: `3`. Strength: `2`.
2. [ ] Call `Fight` twice:
   1. [ ] The first fight should be Aragorn vs Gimli.
   2. [ ] The second will be Legolas vs Frodo.

Run it with `dotnet run -- multiple-objects`.
