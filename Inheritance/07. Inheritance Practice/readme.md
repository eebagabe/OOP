# Inheritance Practice

Siege weapons (battering rams, catapults, etc.) are special units in Age of Dragons. Let's write the logic for how they move around the map.

## Assignment

Complete the `Siege`, `BatteringRam`, and `Catapult` classes:

1. [ ] Complete the `Siege` class:
   1. [ ] Complete the constructor. It accepts two parameters (in order) and sets them as public properties: `MaxSpeed` and `Efficiency`
   2. [ ] Complete the `GetTripCost()` method. It calculates the cost of a trip and returns it. The formula for calculating the cost is: `(distance / efficiency) * foodPrice`. *It costs food to move siege weapons, those things are heavy!*
   3. [ ] Leave the `GetCargoVolume()` method empty, just returning `null`. Mark it as [`virtual`](https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/virtual) so child classes can override this method.
2. [ ] Complete the `BatteringRam` class:
   1. [ ] Complete the constructor. It calls the parent constructor, then sets the extra battering-ram-only properties.
   2. [ ] The `GetTripCost()` method uses the parent `GetTripCost()` method to calculate the cost of food for a trip, plus the extra cost of carrying a load. The formula for calculating the cost: `GetTripCost() + (loadWeight * 0.01)`
   3. [ ] The `GetCargoVolume()` method calculates and returns the cargo capacity in cubic meters. To get the volume of the battering-ram's 'cargo' (`BedArea`), multiply its area by its depth, which is always 2 meters.
3. [ ] Complete the `Catapult` class:
   1. [ ] The constructor calls the parent constructor, then sets the extra catapult-only property.
   2. [ ] Do not override the `GetTripCost()` method. It's inherited from the parent class.
   3. [ ] The `GetCargoVolume()` method just returns the cargo capacity of the catapult. This is already set by the constructor.

## Tips

You know this already: the [base](https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/base) keyword refers to the parent class, so use it to call the parent class's constructor (`: base(...)`) and other methods (`base.GetTripCost(...)`).
