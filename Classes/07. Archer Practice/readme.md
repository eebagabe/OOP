# Archer Practice

Let's practice some of these class and objects concepts a bit more.

## Assignment

**Complete the `Archer` class**.

1. [ ] Complete the constructor. It should take the following parameters in order and set them as instance properties:
   1. [ ] `name`
   2. [ ] `health`
   3. [ ] `numArrows`
2. [ ] Complete the `TakeHit` method. It operates on the current archer instance.
   1. [ ] Remove one health from the current archer.
   2. [ ] If the archer has no health, throw the exception: `{NAME} is dead` where `{NAME}` is the archer's name.
3. [ ] Finish the `Shoot` method. It takes an `Archer` instance as its `target` input.
   1. [ ] If the shooter has no arrows left, [throw an exception](https://learn.microsoft.com/dotnet/csharp/language-reference/statements/exception-handling-statements#the-throw-statement) `{NAME} can't shoot` where `{NAME}` is the shooter's name.
   2. [ ] Otherwise, remove an arrow from the shooter.
   3. [ ] Print `{1} shoots {2}` where `{1}` is the shooter's name and `{2}` is the name of the targeted archer.
   4. [ ] Call the target's `TakeHit()` method.
