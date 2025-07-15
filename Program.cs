using System;

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
}