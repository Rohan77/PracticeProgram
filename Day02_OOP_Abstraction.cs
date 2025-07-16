using System;

namespace PracticePrograms
{
    public abstract class Payment
    {
        public string? TransactionId;

        public void Validate()
        {
            Console.WriteLine("Payment validated.");
        }

        public abstract void Pay(); // no body here
    }

    public class CreditCardPayment : Payment
    {
        public override void Pay()
        {
            Console.WriteLine($"Paid using Credit Card. Transaction ID: {TransactionId}");
        }
    }

    public class UpiPayment : Payment
    {
        public override void Pay()
        {
            Console.WriteLine($"Paid using UPI. Transaction ID: {TransactionId}");
        }
    }

    public static class Day02_OOP_Abstraction
    {
        public static void Run()
        {
            Console.WriteLine("Day 2 - OOP: Abstraction");
            Console.WriteLine();

            Payment p1 = new CreditCardPayment { TransactionId = "TXN12345" };
            p1.Validate(); // concrete method
            p1.Pay();      // abstract implementation

            Payment p2 = new UpiPayment { TransactionId = "TXN67890" };
            p2.Validate();
            p2.Pay();

            /*
            Abstraction means hiding the complex logic and exposing only the essential details

            In C#, abstraction is achieved in two ways:
              1. Abstract class
              2. Interface

            Abstract Class:
            - Declared using the 'abstract' keyword
            - Cannot be instantiated directly
            - Can contain both abstract (no implementation) and non-abstract (concrete) methods
            - Used when you want to provide a common base with some shared logic

            Real-world analogy:
            - "Payment" is abstract. You cannot perform a generic payment.
              But specific types like CreditCardPayment or UpiPayment implement the logic.

            Use cases:
            - BaseController in ASP.NET MVC
            - BaseService or BaseEntity in domain layer
            - Common logging, validation methods shared across child classes

            Difference between 'abstract' and 'virtual':
            - abstract method must be overridden
            - virtual method can be optionally overridden

            Interview Tip:
            - Use abstract class when you want to share default behavior across subclasses
            - Use interface if you only want to define a contract without any implementation
            - Don't overuse abstraction — keep hierarchy shallow and meaningful



What
    Abstraction means hiding implementation details and exposing only essential features to the user.
    It’s about what an object does, not how it does it.
    Achieved in C# using:
        Abstract classes
        Interfaces

Why
    To reduce complexity and increase clarity for the consumer of a class.
    To enforce design contracts — you define what must be done, not how.
    Helps isolate changes — implementation can change without affecting consumers.

When
   When multiple classes must implement the same methods but differently.
   When you want to define a common template or behavior, and leave the specifics to child classes.
   When designing frameworks, SDKs, APIs, and reusable code.

Real-World Analogy
    A remote control exposes buttons like Power, Volume, Channel — but hides the internal wiring and logic.
    You know what to press, not how signals travel inside the TV.

Best Practices
    Use abstract class when you want to provide base functionality with some customizable parts.
    Avoid making everything abstract unless you really want a strict template.
    Combine inheritance with abstraction wisely to avoid tight coupling.
    In shared libraries or APIs, abstraction helps expose a clean public surface.

When to Use Abstract Classes (vs Interfaces)
    When you need to share base functionality or default logic between classes.
    When your API needs to evolve over time with minimum breaking changes.
    When you want to enforce some behavior but leave flexibility for other parts.

 */
        }
    }
}
