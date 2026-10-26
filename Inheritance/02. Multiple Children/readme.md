# Multiple Children

So far we've worked with linear class inheritance, but usually, inheritance hierarchies form trees, not lines. A parent class can have multiple children.

![](https://storage.googleapis.com/qvault-webapp-dynamic-assets/course_assets/Cyv2n6l-1023x400.png)

## Assignment

Ensure the following requirements from the game designers are completed:

1. [ ] `Archer` should inherit from `Hero`.
2. [ ] `Archer` should set up the hero's name and health.
3. [ ] Add a private "number of arrows" field that can be set by the constructor.
4. [ ] Complete the `Shoot` method. It takes a target hero as input.
   1. [ ] If there are no arrows left, throw a `not enough arrows` exception.
   2. [ ] Otherwise, remove an arrow and deal `10` damage to the target hero.
