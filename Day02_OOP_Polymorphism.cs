using System;

namespace PracticePrograms
{
    public class Animal_Poly
    {
        public string? Name;

        public virtual void Speak()
        {
            Console.WriteLine($"{Name} makes a sound (base class).");
        }
    }

    public class Dog_Poly : Animal_Poly
    {
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }
    }

    public class Cat_Poly : Animal_Poly
    {
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }
    }

    public static class Day02_OOP_Polymorphism
    {
        public static void Run()
        {
            Console.WriteLine("Day 2 - OOP: Polymorphism");
            Console.WriteLine();

            Animal_Poly a1 = new Dog_Poly { Name = "Rocky" };
            Animal_Poly a2 = new Cat_Poly { Name = "Whiskers" };

            a1.Speak();  // Dog_Poly.Speak()
            a2.Speak();  // Cat_Poly.Speak()

            /*
            Polymorphism means "many forms"

            In C#, two types of polymorphism exist:

            1. Compile-time Polymorphism (Method Overloading):
               - Same method name with different parameter signatures
               - Resolved by the compiler at compile-time
               - Achieved using method overloading or optional parameters

            2. Runtime Polymorphism (Method Overriding):
               - Achieved using inheritance
               - The base class defines a method as 'virtual'
               - Derived class overrides it using the 'override' keyword
               - Method call is resolved at runtime based on the actual object type

            Example:
                Animal_Poly a = new Dog_Poly();
                a.Speak(); // Will call Dog_Poly.Speak() at runtime

            Real world analogy:
                - Think of a base class called 'Payment'
                - Derived classes: CreditCard, UPI, Cash
                - You write: payment.Pay();
                - The actual object could be of any type
                - At runtime, the correct payment method is called automatically

            What if you skip virtual/override?
                - Then method binding is static
                - The base class method is always called, regardless of actual object type
                - This is called early binding or static dispatch
                - True polymorphism does not occur

            Real-world use cases where polymorphism is heavily used:

            - UI frameworks: 
              Example - Button, TextBox, Label inherit from Control; each overrides Draw()
            
            - Game engines:
              Example - GameObject base class, different NPCs or Players override behaviors

            - Dependency Injection:
              You register and resolve interface or base type, but runtime injects derived implementation

            - Design Patterns:
              Strategy Pattern, State Pattern, Template Method – all rely on polymorphism to switch behavior at runtime

            Interview Tip:
            - Always mark base method as 'virtual' and child as 'override'
            - Polymorphism is central to extensible and maintainable design
            - Avoid static binding unless you are intentionally optimizing for performance or simplicity




What
    Polymorphism means "many forms".
    It allows one interface or base class to be used with different underlying types at runtime.
    Two types:
        Compile-time (Method Overloading)
        Run-time (Method Overriding via virtual/override)

Why
    Enables flexibility and extensibility in large systems.
    You can write code that works with base types, but behaves differently depending on the derived type.
    Encourages loose coupling and plug-and-play architecture.

When
    When you want to allow different classes to provide their own implementation for shared functionality.
    When you want to swap behavior at runtime without changing code that uses it.
    Common in UI frameworks, game engines, plugins, design patterns like Strategy, State, Factory.

Real-World Analogy
    A remote control (base type) controls multiple devices (TV, AC, Projector).
    When you press “Power On”, each device behaves differently, but the interface is same.
    Same command — many behaviors.

Best Practices
    Always make base methods virtual only when needed.
    Prefer interface-based polymorphism for better abstraction and testability.
    Don't overuse inheritance — it can make design rigid.
    Avoid hiding methods (use new keyword carefully — not true polymorphism).
When to Use
    When you want to process different types using the same logic path (like lists of base types).
    When you follow SOLID principles — especially Open/Closed Principle.
    When using frameworks that rely on base interfaces like ILogger, IDisposable, DbContext.

*/
        }
    }
}
