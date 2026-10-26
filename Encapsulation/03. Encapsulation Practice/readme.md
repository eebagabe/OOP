# Encapsulation Practice

Age of Dragons is a game about resource management and strategy. The game has a feature that allows players to manage their resources in a bank. The bank has a feature that allows players to deposit and withdraw funds.

## Assignment

Complete the `BankAccount` class.

1. [ ] Complete the constructor
   1. [ ] Set `_accountNumber` to `accountNumber`
   2. [ ] Set `_balance` to `initialBalance`
2. [ ] Complete the public getters
   1. [ ] Complete the `GetAccountNumber` method to get the value of the private field `_accountNumber` and `return` it.
   2. [ ] Complete the `GetBalance` method to get the value of the private field `_balance` and `return` it.
3. [ ] Complete the `Deposit` method
   1. [ ] It should accept an `amount` as input and add it to the account `balance`.
   2. [ ] If the deposit amount isn't positive, it should `throw` an [ArgumentException](https://learn.microsoft.com/dotnet/api/system.argumentexception) with the message `cannot deposit zero or negative funds`. Otherwise, it should add the amount to the balance.
4. [ ] Complete the `Withdraw` method
   1. [ ] It should accept an `amount` and check if there is enough money in the account for the withdrawal.
   2. [ ] If the withdrawal amount isn't positive, it should `throw` an `ArgumentException` with the message `cannot withdraw zero or negative funds`.
   3. [ ] Then, if there are *not* enough funds it should `throw` an `ArgumentException` with the message `insufficient funds`.
   4. [ ] Otherwise, it should deduct the `amount` from the balance.
