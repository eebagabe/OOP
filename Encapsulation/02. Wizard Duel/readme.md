# Wizard Duel

Let's give our wizards the ability to launch fireballs *at each other*.

## Assignment

1. [ ] Complete the `CastFireball` method:
   1. [ ] If there isn't enough mana to cast a fireball (based on the `fireballCost` argument), `throw` an `Exception` with the message `____ cannot cast fireball`, where `____` is the wizard's name.
   2. [ ] If the wizard has enough mana, reduce their mana by the `fireballCost` and call `GetFireballed` on the target wizard with the given `fireballDamage`.
2. [ ] Complete the `IsAlive` method. It should return `true` if the wizard's health is greater than `0` and `false` otherwise.
