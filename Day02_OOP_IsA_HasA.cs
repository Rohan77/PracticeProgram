using System;

namespace PracticePrograms
{
    public static class Day02_OOP_IsA_HasA
    {


// HAS-A: Person HAS-A Address
    public class Address
    {
        public string? City;
        public string? ZipCode;
    }

    public class Person_Comp
    {
        public string? Name;
        public Address? Address; // Composition

        public void ShowPerson()
        {
            Console.WriteLine($"{Name} lives in {Address?.City} - {Address?.ZipCode}");
        }
    }

 // IS-A: Car IS-A Vehicle
    public class Vehicle
    {
        public string? Brand;
        public void Start()
        {
            Console.WriteLine($"{Brand} engine started.");
        }
    }

    public class Car : Vehicle
    {
        public string? Model;

        public void ShowCar()
        {
            Console.WriteLine($"This is a {Brand} {Model}");
        }
    }


        
        public static void Run()
        {
            Console.WriteLine("Day 2 - OOP: IS-A vs HAS-A");
            Console.WriteLine();

            // IS-A: Car inherits from Vehicle
            Car c = new Car { Brand = "Toyota", Model = "Innova" };
            c.Start();      // From Vehicle
            c.ShowCar();    // From Car

            Console.WriteLine();

            // HAS-A: Person has an Address
            Address addr = new Address { City = "Pune", ZipCode = "411017" };
            Person_Comp p = new Person_Comp { Name = "Rohan", Address = addr };
            p.ShowPerson();

            /*
            IS-A = Inheritance:
            - "Car IS-A Vehicle" — use inheritance when child is a type of parent
            - Allows reuse of behavior via base class
            - Useful when you want to extend or specialize existing functionality

            HAS-A = Composition:
            - "Person HAS-A Address" — one object owns or uses another
            - Promotes loose coupling and flexibility
            - Preferred over inheritance in modern design

            Real-world:
            - IS-A: Dog IS-A Animal, SavingsAccount IS-A BankAccount
            - HAS-A: Car HAS-A Engine, Order HAS-A List<Item>

            Use Case Tip:
            - Use inheritance when there is clear type hierarchy
            - Use composition when class needs to reuse functionality of multiple types

            Interview Tip:
            - Composition is more flexible, supports better design principles like SOLID
            - In real-world projects, prefer HAS-A (composition) over IS-A



What
    IS-A represents an inheritance relationship — one class is a specialized version of another.
    HAS-A represents a composition relationship — one class contains or uses another class.

Why
    To decide the right design approach for your class relationships.
    To follow Object-Oriented Design principles and keep systems extensible, decoupled, and maintainable.
    Avoid misuse of inheritance — which often leads to tight coupling and fragile code.

When
    Use IS-A (inheritance) when there is a clear hierarchy and shared behavior that can be extended.
    Use HAS-A (composition) when one object uses another to do its work or contains it as part of its state.
    Modern design prefers composition over inheritance for flexibility.

Best Practices
    Default to composition when possible.
    Use inheritance only when:
        There’s a genuine “is-a” relationship
        You need polymorphic behavior
        You are working with a base framework or abstract contract
    Avoid deep inheritance chains — prefer interfaces and composition instead.

*/
        }
    }
}
