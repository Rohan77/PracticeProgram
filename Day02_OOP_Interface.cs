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




What
    Interface defines a contract — a set of methods/properties a class must implement, but no implementation is provided (till C# 8 default methods).
    Abstract class can provide both abstract members (no body) and concrete members (with logic).
    Both are used to define base behavior, but differ in purpose and usage.

Why
    To enforce common behavior across unrelated classes.
    To support polymorphism and loose coupling.
    Interface allows multiple inheritance; abstract class allows base implementation.

When
    Use an interface when:
        You need to define capabilities (e.g., IPrintable, IDisposable)
        You want to apply behavior across unrelated classes
        You need multiple inheritance
    Use an abstract class when:
        You want to provide a base implementation
        You want to force certain behavior while allowing extensibility
        You want to avoid code duplication among related types

Real-World Analogy
    Interface: A contract like “Driver's License”. Anyone who drives must follow the rules — doesn’t matter if it’s a car, truck, or bike.
    Abstract Class: A base product template. You get a semi-finished product and must customize parts of it.

Best Practices
    Use interfaces to represent behavior or capabilities.
    Use abstract classes to share common functionality across related classes.
    If in doubt, start with interface — it's more flexible.
    Prefer interfaces in frameworks, libraries, and public APIs for extensibility.
    Avoid mixing abstract class and interface unnecessarily unless needed for framework design.
 */
        }
    }
}
