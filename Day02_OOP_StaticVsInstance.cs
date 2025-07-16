using System;

namespace PracticePrograms
{
    public class Counter
    {
        public int InstanceCount = 0;
        public static int StaticCount = 0;

        public Counter()
        {
            InstanceCount++;
            StaticCount++;
        }
    }

    public static class Day02_OOP_StaticVsInstance
    {
        public static void Run()
        {
            Console.WriteLine("Day 2 - OOP: Static vs Instance Members");
            Console.WriteLine();

            Counter c1 = new Counter();
            Console.WriteLine($"Object 1 - InstanceCount: {c1.InstanceCount}, StaticCount: {Counter.StaticCount}");

            Counter c2 = new Counter();
            Console.WriteLine($"Object 2 - InstanceCount: {c2.InstanceCount}, StaticCount: {Counter.StaticCount}");

            Counter c3 = new Counter();
            Console.WriteLine($"Object 3 - InstanceCount: {c3.InstanceCount}, StaticCount: {Counter.StaticCount}");

            /*
            Instance Members:
            - Belong to individual objects
            - Each object has its own separate copy of instance fields

            Static Members:
            - Belong to the class, not the object
            - Shared across all objects
            - Use 'ClassName.StaticMember' to access

            In this example:
            - InstanceCount is reset to 0 for every new object
            - StaticCount keeps increasing as it's shared by all instances

            Real-world analogy:
            - Instance: Your bank account balance — unique to you
            - Static: Bank interest rate — same for all customers

            Use cases for static:
            - Global settings (e.g., Configuration)
            - Singleton patterns
            - Helper/utility classes (e.g., Math.Round, string.IsNullOrEmpty)

            Interview Tip:
            - Static constructor runs only once per type
            - Static members can't access non-static members directly
            - Avoid excessive static usage — it reduces testability and flexibility


What
    Instance members belong to an object — each object has its own copy of the member.
    Static members belong to the class itself — shared across all instances.
    Applies to fields, methods, constructors, and even classes.

Why
    Use instance members when each object needs separate state or behavior.
    Use static members when data or behavior is common across all objects or doesn’t depend on instance.
    Helps manage global/shared logic, caching, utility methods, or counters.

When
    Use instance when modeling real-world objects with unique states (e.g., Customer, Order, Product).
    Use static when logic is independent of object (e.g., Math.Round, DateTime.Now, or logger instances).
    Also useful for singleton pattern, counters, or in-memory caches.

Real-World Analogy
    Instance: Each person has their own mobile phone number. It belongs to that person only.
    Static: The emergency helpline number is shared — anyone can use it, and it’s always the same.

 Best Practices
    Keep static classes stateless — avoid side effects and mutable static fields.
    Avoid unnecessary static usage — can lead to tight coupling and testability issues.
    Static constructors are useful for one-time initialization (e.g., connection string setup).
    Use static fields cautiously in multi-threaded scenarios — consider thread safety.   

 */
        }
    }
}
