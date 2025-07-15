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
            */
        }
    }
}
