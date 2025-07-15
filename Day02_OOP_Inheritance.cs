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
            */
        }
    }
}
