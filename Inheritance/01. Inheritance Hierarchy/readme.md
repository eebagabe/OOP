# Inheritance Hierarchy

There is no (technical) limit to how deeply we can nest an inheritance tree. For example:

`Tiger` inherits from `Feline` inherits from `Animal` inherits from `LivingThing`.

That said, *be careful*! New programmers often get carried away. You should never think to yourself:

> "Well *most* wizards are elves... so I'll just have `Wizard` inherit from `Elf`"

A good child class is a strict [subset](https://en.wikipedia.org/wiki/Subset) of its parent class.

## Assignment

Let's add a new game unit: `Crossbowman`. A crossbowman is always an archer, but not all archers are crossbowmen. Crossbowmen have several arrows, but they have an additional method: `TripleShot()`.

1. [ ] Complete the `UseArrows` method on the `Archer` class. It should remove `num` arrows, but if there aren't enough arrows to remove, it should throw a `not enough arrows` exception instead.
2. [ ] Complete the `Crossbowman` class.
   - [ ] Its constructor should call its parent's constructor.
   - [ ] Its `TripleShot` method should:
     - Use `3` arrows
     - Return the string `TARGET was shot by 3 crossbow bolts` where `TARGET` is the name of the `Human` that was shot (any `Human` can be a target).
