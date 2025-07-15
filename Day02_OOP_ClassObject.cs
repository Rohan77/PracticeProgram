using System;

namespace PracticePrograms
{
    public class Person
    {
        public string? Name;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine($"Hi, I’m {Name} and I’m {Age} years old.");
        }
    }

    public static class Day02_OOP_ClassObject
    {
        public static void Run()
        {
            Console.WriteLine("Day 2 – OOP: Class & Object\n");

            Person p1 = new Person();
            p1.Name = "Rohan";
            p1.Age = 30;
            p1.Introduce();

            Person p2 = new Person { Name = "Gatha", Age = 4 };
            p2.Introduce();

            /*
            Class:
            - A class is a blueprint — it defines structure and behavior of an object.
            - Doesn't occupy memory until you create an object.

            Object:
            - An object is an instance of a class. It holds data in memory.
            - Each object has its own copy of non-static fields.

            Real-world Analogy:
            - Class: "Car" blueprint (defines color, speed, fuel)
            - Object: A specific "red Swift" created from that blueprint

            Interview Tip:
            - Class = definition; Object = actual memory allocation
            - Each object can have different state (data) but share same behavior (methods)
            */
        }
    }
}
