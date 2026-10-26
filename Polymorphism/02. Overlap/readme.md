# Overlap

![](https://storage.googleapis.com/qvault-webapp-dynamic-assets/course_assets/cVTThOL-530x400.png)

Time to write the logic that determines if two rectangles overlap!

## Assignment

**Complete the `Overlaps()` method**. It should check if the current rectangle (`this`) overlaps a given rectangle (`rect`).

Return `true` if `this` overlaps any part of `rect`, including just touching sides. Return `false` otherwise.

## Tips

All the following conditions must be `true` for the rectangles (let's call them `A` and `B`) to overlap:

- A's left side is on or to the left of B's right side
- A's right side is on or to the right of B's left side
- A's top side is on or above B's bottom side
- A's bottom side is on or below B's top side
