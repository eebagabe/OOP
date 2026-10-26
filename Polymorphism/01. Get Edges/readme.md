# Get Edges

In the last chapter we checked if a unit's `(x, y)` **point** was within a rectangle (the Dragon's breath). But units aren't really points: they have their own areas.

So we're going to check if a dragon's body (a rectangle) is within the fire (also a rectangle). The image below contains an example of fire breath hitting a dragon.

![](https://storage.googleapis.com/qvault-webapp-dynamic-assets/course_assets/cVTThOL-530x400.png)

Later we'll write the `Overlaps` method, but first we'll just write a method to find the edges of a rectangle.

## Assignment

We changed the coordinates themselves to be private fields. We now need to write `getter` methods to access them.

**Complete the following methods**:

1. [ ] `GetLeftX()`: Returns the leftmost (smallest) x value
2. [ ] `GetRightX()`: Returns the rightmost (largest) x value
3. [ ] `GetTopY()`: Returns the topmost (largest) y value
4. [ ] `GetBottomY()`: Returns the bottom-most (smallest) y value

Remember that we're working with a standard [Cartesian plane](https://en.wikipedia.org/wiki/Cartesian_coordinate_system).

We will explain the `ToString` override later, don't worry too much about it.

## Tips

You may find the [Math.Min](https://learn.microsoft.com/dotnet/api/system.math.min) and [Math.Max](https://learn.microsoft.com/dotnet/api/system.math.max) methods useful.
