using System;

namespace PracticePrograms
{
    public class Person_Ctor
    {
        public string? Name;
        public int Age;

        // 1. Default constructor
        public Person_Ctor()
        {
            Name = "Unknown";
            Age = 0;
        }

        // 2. Parameterized constructor
        public Person_Ctor(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // 3. Constructor chaining using 'this'
        public Person_Ctor(string name) : this(name, 18)
        {
            // If only name is passed, set default age = 18
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} is {Age} years old.");
        }
    }

    public class Utility
    {
        // 4. Static constructor
        static Utility()
        {
            Console.WriteLine("Static constructor called (only once).");
        }

        public static void SayHello()
        {
            Console.WriteLine("Hello from Utility.");
        }
    }

    public static class Day02_OOP_Constructors
    {
        public static void Run()
        {
            Console.WriteLine("Day 2 - OOP: Constructor Types");
            Console.WriteLine();

            Person_Ctor p1 = new Person_Ctor();
            p1.PrintInfo();

            Person_Ctor p2 = new Person_Ctor("Rohan", 30);
            p2.PrintInfo();

            Person_Ctor p3 = new Person_Ctor("Gatha");
            p3.PrintInfo();

            Utility.SayHello();

            /*
            Constructor is a special method called when an object is created.
            It initializes the object state.

            Types of Constructors in C#:

            1. Default Constructor:
               - No parameters
               - If you don't define any, compiler provides one automatically
               - Used when no specific data is passed
               - Real-world: When you sign up on a website without filling optional profile info

            2. Parameterized Constructor:
               - Accepts arguments to initialize values during object creation
               - Real-world: Booking a flight by entering name, email, age at the time of account creation

            3. Constructor Chaining:
               - One constructor calls another using 'this(...)'
               - Helps reuse initialization logic
               - Used to reuse initialization logic and reduce duplicate code
               - Real-world: Setting default country as 'India' if not provided

            4. Static Constructor:
               - Declared using 'static'
               - Called automatically before first use of the class (no manual call)
               - Used to initialize static data
               - Runs only once per type in entire application lifetime
               - Used to load static config like environment variables or license keys
               - Real-world: When a mobile app loads app settings (theme, language) once on startup

            Rules:
            - Static constructor can't take parameters
            - You can't call it explicitly
            - Instance constructor runs every time you use 'new'

            Interview Tip:
            - Use constructor overloading to simplify object creation
            - Static constructor is great for initializing static variables or configuration
            - If both static and instance constructors exist, static runs first

            Why Constructors Matter in Real Projects:

            - Helps enforce required values during object creation
            Example: In an Invoice class, force invoice number and date in constructor

            - Makes object creation readable and safe
            Example: `new User("Rohan", "Admin")` is more readable than setting properties one by one

            - Static constructors help in loading shared data:
            Example: Logging configuration, database connection string, or culture info

            Interview Tip:

            - Constructor chaining is often used in base-entity classes for default timestamps
            - Static constructors are useful in Singleton patterns
            - Parameterized constructors are mandatory in Domain-Driven Design (DDD) entities

            In our previous project, we used parameterized constructors in domain models like Invoice, User, and used static constructors to initialize shared configuration settings using appsettings.json
            */
        }
    }
}
