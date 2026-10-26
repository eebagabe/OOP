# Encapsulation

[Encapsulation](<https://en.wikipedia.org/wiki/Encapsulation_(computer_programming)>) is the practice of hiding complexity inside a ["black box"](https://en.wikipedia.org/wiki/Black_box) so that it's easier to focus on the problem at hand.

![](https://storage.googleapis.com/qvault-webapp-dynamic-assets/course_assets/8gu3Y0s-964x544.png)

The simplest example of encapsulation is a function. The caller of a function doesn't need to worry too much about what happens inside, they just need to understand the inputs and outputs.

```csharp
// who even knows how this function works???
// I sure don't, I just call it and assume
// it calculates the acceleration correctly
var acceleration = CalcAcceleration(initialSpeed, finalSpeed, time);
```

To *use* the `CalcAcceleration` function, we don't need to think about each line of code inside the function definition. We just need to know that if we give it the inputs:

- `initialSpeed`
- `finalSpeed`
- `time`

It will produce the correct `acceleration` as an output.

## Public and Private

Members marked as `public` can be accessed from anywhere with the `.` operator:

```csharp
wall.Height = 10;
Console.WriteLine(wall.Height);
// 10
```

[Private](https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/private) members are a way to encapsulate logic and data *within a class definition*. To make a field or method private, mark it with the `private` keyword (by convention, private fields are prefixed with an underscore):

```csharp
public class Wall
{
    private int _armor;
    private int _magicResistance;

    public Wall(int armor, int magicResistance)
    {
        _armor = armor;
        _magicResistance = magicResistance;
    }

    public int GetDefense()
    {
        return _armor + _magicResistance;
    }
}

var frontWall = new Wall(10, 20);

// This doesn't even compile
Console.WriteLine(frontWall._armor);

// This works
Console.WriteLine(frontWall.GetDefense());
// 30
```

We do this to make it *easier to use our class*. Now when another developer (or even ourselves) use the `Wall` class, they don't need to think about how `armor` and `magicResistance` affect the `defense` of a `Wall`. In fact, we don't even allow them to access `_armor` and `_magicResistance` directly by making them `private`.

They simply call the public `GetDefense()` method and know that the correct value will be returned.

## Assignment

Complete the `Wizard` class's constructor.

1. [ ] Set 2 **private** fields:
   1. [ ] `_stamina`
   2. [ ] `_intelligence`
2. [ ] Set 3 public properties:
   1. [ ] `Name`: Use the value passed into the constructor
   2. [ ] `Health`: 100x the value of "stamina"
   3. [ ] `Mana`: 10x the value of "intelligence"
