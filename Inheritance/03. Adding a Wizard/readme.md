# Adding a Wizard

Let's extend the `Hero` class by adding a second child class: the `Wizard`. Wizard heroes are more powerful than archer heroes. They cast spells at other heroes instead of shooting them, and casting does `25` damage instead of `10` but also costs `25` mana.

## Assignment

**Complete the `Wizard` class**.

1. [ ] `Wizard` should inherit from `Hero`.
2. [ ] `Wizard` should set up the hero's name and health.
3. [ ] Set a private `_mana` field that can be passed in as a third parameter to the constructor.
4. [ ] Create a `Cast` method that takes a target hero as input.
   1. [ ] If there is less than `25` mana left, throw a `not enough mana` exception.
   2. [ ] Otherwise, remove `25` mana from the wizard and deal `25` damage to the target hero.
