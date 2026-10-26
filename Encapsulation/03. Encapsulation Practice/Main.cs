namespace ObjectOriented.Encapsulation.EncapsulationPractice;

public class BankAccount
{
    private string _accountNumber;
    private decimal _balance;

    public BankAccount(string accountNumber, decimal initialBalance)
    {
        _accountNumber = accountNumber;
        _balance = initialBalance;
    }

    public string GetAccountNumber()
    {
        return _accountNumber;
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("cannot deposit zero or negative funds");
        }

        _balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("cannot withdraw zero or negative funds");
        }

        if (_balance < amount)
        {
            throw new ArgumentException("insufficient funds");
        }

        _balance -= amount;
    }
}
