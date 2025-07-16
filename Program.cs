

using System;
using System.Collections.Generic;

namespace PracticePrograms
{
    class Program
    {
        // Map: option key  →  (menu label, method to execute)
        private static readonly Dictionary<string, (string Label, Action Run)> Topics =
            new()
            {
                { "1",  ("Day 1 - Value vs Reference",        Day01_ValueVsReference.Run) },
                { "2",  ("Day 2 - Boxing and Unboxing",       Day02_BoxingUnboxing.Run)   },
                { "3",  ("Day 2 - OOP: Class & Object",       Day02_OOP_ClassObject.Run)  },
                { "4",  ("Day 2 - OOP: Inheritance",          Day02_OOP_Inheritance.Run)  },
                { "5",  ("Day 2 - OOP: Polymorphism",         Day02_OOP_Polymorphism.Run) },
                { "6",  ("Day 2 - OOP: Abstraction",          Day02_OOP_Abstraction.Run)  },
                { "7",  ("Day 2 - OOP: Interface",            Day02_OOP_Interface.Run)    },
                { "8",  ("Day 2 - OOP: Encapsulation",        Day02_OOP_Encapsulation.Run)},
                { "9",  ("Day 2 - OOP: Static vs Instance",   Day02_OOP_StaticVsInstance.Run)},
                { "10", ("Day 2 - OOP: Constructor Types",    Day02_OOP_Constructors.Run) },
                { "11", ("Day 2 - OOP: IS-A vs HAS-A",        Day02_OOP_IsA_HasA.Run)     },
                { "12", ("Day 3 - Delegates",                 Day03_Delegates.Run)        },
                { "13", ("Day 3 - Events",                    Day03_Events.Run)           },
                { "14", ("Day 3 - Func<T> examples",          Day03_Func.Run)             },
                { "15", ("Day 3 - Action<T> examples", Day03_Action.Run) },
                { "16", ("Day 3 - Predicate<T> examples", Day03_Predicate.Run) }
            };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nSelect a program to run:");
                foreach (var item in Topics)
                    Console.WriteLine($"{item.Key}. {item.Value.Label}");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");

                // ReadLine may return null; handle it safely
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid choice. Try again.");
                    continue;
                }

                string choice = input.Trim();

                if (choice == "0")
                {
                    Console.WriteLine("Exiting...");
                    return;
                }

                if (Topics.TryGetValue(choice, out var topic))
                {
                    Console.WriteLine();
                    topic.Run();   // execute selected demo
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                }
            }
        }

    }
}









/* using System;

namespace PracticePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n📘 Select a program to run:");
                Console.WriteLine("1. Day 1 - Value vs Reference");
                Console.WriteLine("2. Day 2 - Boxing and Unboxing");
                Console.WriteLine("3. Day 2 - OOP: Class & Object");
                Console.WriteLine("4. Day 2 – OOP: Inheritance");
                Console.WriteLine("5. Day 2 - OOP: Polymorphism");
                Console.WriteLine("6. Day 2 - OOP: Abstraction");
                Console.WriteLine("7. Day 2 - OOP: Interface");
                Console.WriteLine("8. Day 2 - OOP: Encapsulation");
                Console.WriteLine("9. Day 2 - OOP: Static vs Instance");
                Console.WriteLine("10. Day 2 - OOP: Constructor Types");
                Console.WriteLine("11. Day 2 - OOP: IS-A vs HAS-A");
                Console.WriteLine("12. Day 3 - Delegates");
                Console.WriteLine("13. Day 3 - Events");
                Console.WriteLine("14. Day 3 - Func<T> examples");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Day01_ValueVsReference.Run();
                        break;
                    case "2":
                        Day02_BoxingUnboxing.Run(); 
                        break;
                    case "3":
                        Day02_OOP_ClassObject.Run(); 
                        break;
                    case "4":
                        Day02_OOP_Inheritance.Run();
                        break;
                    case "5":
                        Day02_OOP_Polymorphism.Run();
                        break;
                    case "6":
                        Day02_OOP_Abstraction.Run();
                        break;
                    case "7":
                        Day02_OOP_Interface.Run();
                        break;
                    case "8":
                        Day02_OOP_Encapsulation.Run();
                        break;
                    case "9":
                        Day02_OOP_StaticVsInstance.Run();
                        break;
                    case "10":
                        Day02_OOP_Constructors.Run();
                        break;
                    case "11":
                        Day02_OOP_IsA_HasA.Run();
                        break;
                    case "12":
                        Day03_Delegates.Run();
                        break;
                    case "13":
                        Day03_Events.Run();
                        break;
                    case "14":
                        Day03_Func.Run();
                        break;
                    case "0":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
} */