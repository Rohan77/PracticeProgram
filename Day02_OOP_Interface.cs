using System;

namespace PracticePrograms
{
    public interface IPayment
    {
        string? TransactionId { get; set; }
        void Pay();
    }

    public class CreditCard : IPayment
    {
        public string? TransactionId { get; set; }

        public void Pay()
        {
            Console.WriteLine($"Credit Card Payment. Transaction ID: {TransactionId}");
        }
    }

    public class Upi : IPayment
    {
        public string? TransactionId { get; set; }

        public void Pay()
        {
            Console.WriteLine($"UPI Payment. Transaction ID: {TransactionId}");
        }
    }

    public static class Day02_OOP_Interface
    {
        public static void Run()
        {
            Console.WriteLine("Day 2 - OOP: Interface");
            Console.WriteLine();

            IPayment p1 = new CreditCard { TransactionId = "TXN111" };
            IPayment p2 = new Upi { TransactionId = "TXN222" };

            p1.Pay();
            p2.Pay();

            /*
            Interface means "contract" — it defines what methods/properties a class must implement

            Key points:
            - Declared using 'interface' keyword
            - Cannot contain any implementation (except default interface methods from C# 8+)
            - A class can implement multiple interfaces
            - Members are public by default — no access modifiers allowed
            - Cannot have fields, only properties, methods, events, indexers

            Real-world analogy:
            - IPayment is a contract. Any class (UPI, CreditCard, PayPal) that promises to implement it must provide its own Pay() logic

            Use cases:
            - Service interfaces in Dependency Injection (like ILogger, IRepository)
            - Defining behaviors that may be shared across unrelated classes (like IDrivable, ISavable)
            - Supporting multiple inheritance

            Interface vs Abstract Class:

            - Interface = only declaration, no implementation (until C# 8.0 default methods)
            - Abstract class = partial implementation allowed
            - A class can implement multiple interfaces but inherit only one base class
            - Interface is used for defining capabilities; abstract class for sharing base logic

            Interview Tip:
            - Prefer interfaces when building scalable, decoupled architecture
            - Interface segregation and dependency inversion principles are built on interfaces
            - Most real-world .NET projects rely heavily on interfaces for unit testing and mocking
            */
        }
    }
}
