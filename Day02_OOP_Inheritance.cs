using System;

namespace PracticePrograms
{
    // Base class (Parent)
    public class Animal
    {
        public string? Name;

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public virtual void Speak()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }
    }

    // Derived class (Child)
    public class Dog : Animal
    {
        public string? Breed;

        public void Bark()
        {
            Console.WriteLine($"{Name} the {Breed} is barking.");
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }
    }

    public static class Day02_OOP_Inheritance
    {
        public static void Run()
        {
            Console.WriteLine("Day 2 – OOP: Inheritance\n");

            Dog dog = new Dog();
            dog.Name = "Rocky";
            dog.Breed = "Labrador";

            dog.Eat();     // inherited from Animal
            dog.Bark();    // defined in Dog
            dog.Speak();   // overridden from Animal

            /*
             Inheritance:
            - Allows a class to reuse code from another class (base/parent).
            - Promotes code reusability and cleaner architecture.
            - C# supports single class inheritance (one base class only).

             IS-A Relationship:
            - Dog IS-A Animal 
            - But Animal is NOT necessarily a Dog 

             Types of Inheritance:
            - Single (Dog : Animal) 
            - Multilevel (Puppy : Dog : Animal) 
            - Multiple via interfaces only (not with classes) 

             Interview Tip:
            - Use inheritance when multiple classes share common behavior.
            - Use virtual/override when you want to change base behavior in child.


        What
            Inheritance is an object-oriented programming principle where one class (child) acquires the properties and behaviors of another class (parent).
            Enables code reuse, specialization, and hierarchical structure in your application.

        Why
            To avoid code duplication and promote reuse of common functionality.
            To build extensible and easily maintainable systems.
            Supports polymorphism — enabling objects to be treated as their parent type.

        When
            When you have an “is-a” relationship.
            Example: Dog is an Animal, Car is a Vehicle.
            When multiple classes share common features (fields, methods).
            When you want to extend or modify behavior of a base class.
            When you want to create a hierarchy of classes.
            When you want to override or extend base behavior in derived classes.
            When you want to implement polymorphism.
            When you want to create a base class that can be used as a type for multiple derived classes.
            When you want to create a common interface for multiple classes.
            When you want to create a base class that can be used to define common properties and methods for derived classes.

    Real-World Analogy
        Parent-child relationship: A child inherits traits from their parents.
        Vehicle inheritance: Car, Bike, and Truck all inherit wheels, engine from Vehicle but add their own features.


    Best Practices
        Use inheritance only for “is-a” relationships — not just to share code.
        Prefer composition over inheritance if relationship is not strict.
        Avoid deep inheritance chains (more than 2–3 levels becomes fragile).
        Keep base classes focused and small to reduce tight coupling.

    When to Avoid Inheritance
        If the child class does not truly follow the base class contract, avoid inheritance.
        If functionality is shared, prefer interfaces or composition.
        Use abstract classes if base behavior should not be instantiated directly.

            */
        }
    }
}
