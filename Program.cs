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
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Day01_ValueVsReference.Run();
                        break;
                    case "2":
                       // Day02_BoxingUnboxing.Run();  // Add this class next
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