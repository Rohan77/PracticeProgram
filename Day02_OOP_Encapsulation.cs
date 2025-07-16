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


What
    Encapsulation means binding data (fields) and methods (behavior) together in a single unit — a class.
    It also means restricting direct access to an object’s internal state and requiring interaction through public methods or properties.

Why
    To protect object integrity by controlling how data is accessed or modified.
    To achieve data hiding — reduce risk of misuse or corruption.
    Makes code more maintainable, modular, and secure.

When
    When designing classes where internal details should be hidden from consumers.
    When you want to allow access to data only through controlled logic (getters/setters, validations).
    When following SOLID principles, especially the Single Responsibility and Open/Closed principles.
Real-World Analogy
    Think of a vending machine — you don’t access the internal parts or coins directly.
    You interact through buttons and the money slot. Machine controls the internal flow.
    Similarly, a class hides its internal logic and exposes a safe interface.

Best Practices
    Make all fields private by default — expose only what’s needed.
    Use properties instead of public fields for future flexibility.
    Group related data and behavior in one class — that’s encapsulation.
    Keep internal implementation abstracted behind clean interfaces.

When to Avoid
    Avoid exposing internal state via public fields — breaks encapsulation.
    Don't make everything public for quick access — leads to tightly coupled, fragile design.


 */
        }
    }
}
