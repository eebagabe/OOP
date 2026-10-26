# Sprint

In `Age of Dragons`, humans can "sprint" to move twice as fast. However, sprinting requires `_stamina`. Each time a human sprints, it loses stamina. Once it is out of stamina, it can no longer sprint.

## Assignment

Complete all the missing methods:

1. [ ] Complete the private helper methods, which are intended to be used by the other four sprinting methods.
   1. [ ] `RaiseIfCannotSprint()`: Throw the exception: `not enough stamina to sprint` if the human is out of stamina.
   2. [ ] `UseSprintStamina()`: Remove one stamina from the human.
2. [ ] For each of the sprint methods:
   1. [ ] Throw an exception if there isn't enough stamina to sprint (use `RaiseIfCannotSprint()`).
   2. [ ] Use the stamina needed to sprint (use `UseSprintStamina()`)
   3. [ ] Move *twice* in the direction of the sprint.
