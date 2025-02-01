using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // Example of Abstraction in C#
        BankAccount account = new BankAccount(1000);
        account.Deposit(500);
        account.Withdraw(200);
        Console.WriteLine($"Current Balance: {account.GetBalance()}");
    }
}

// What is Abstraction?
// Abstraction is all about keeping things simple by showing only what’s necessary and hiding the complicated stuff. 
// Think of it like a car—you don’t need to know how the engine works to drive it, just how to steer, accelerate, and brake. 

// Why does it matter?
// It helps make code cleaner, easier to update, and less of a headache to work with. 
// You can change how things work under the hood without breaking the parts that rely on them.

class BankAccount
{
    private decimal balance; // The balance is kept private so it can't be changed directly

    public BankAccount(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
            balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount > 0 && balance >= amount)
        {
            balance -= amount;
            return true;
        }
        return false;
    }

    public decimal GetBalance()
    {
        return balance;
    }
}
