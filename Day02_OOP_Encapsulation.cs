using System;

namespace PracticePrograms
{
    public class BankAccount
    {
        private decimal balance;

        public string? AccountHolderName { get; set; }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }

    public static class Day02_OOP_Encapsulation
    {
        public static void Run()
        {
            Console.WriteLine("Day 2 - OOP: Encapsulation");
            Console.WriteLine();

            BankAccount acc = new BankAccount();
            acc.AccountHolderName = "Rohan";

            acc.Deposit(1000);
            acc.Withdraw(300);

            Console.WriteLine($"Balance for {acc.AccountHolderName} is: {acc.GetBalance()}");

            /*
            Encapsulation means "wrapping data and behavior together in a single unit (class)"

            Key idea:
            - Keep fields private to protect them from outside modification
            - Expose only required functionality via public methods or properties

            In this example:
            - The 'balance' field is private (not accessible outside directly)
            - Only controlled methods (Deposit, Withdraw) can change balance
            - This ensures data safety and business rule enforcement

            Real-world analogy:
            - ATM machine: You can't directly access money inside.
              You interact using buttons (interface) and rules are enforced internally

            Benefits of Encapsulation:
            - Prevents external code from putting object in invalid state
            - Hides internal complexity of logic
            - Makes the class easier to maintain and update
            - Helps achieve modularity and testability

            Interview Tip:
            - Always use private fields with public getters/setters or methods
            - C# auto-properties (public string Name { get; set; }) simplify encapsulation
            - Use validation inside setters/methods to protect object state
            */
        }
    }
}
