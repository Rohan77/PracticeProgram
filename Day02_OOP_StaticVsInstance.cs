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
            */
        }
    }
}
