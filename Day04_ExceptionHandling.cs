using System;
using System.IO;

namespace PracticePrograms
{
    /*
    Topic: Exception Handling (try, catch, finally, using, custom exception)

    What:
    - Exception: An unexpected runtime error that disrupts normal program flow.
    - try-catch: To detect and handle exceptions gracefully.
    - finally: Block that executes whether exception occurs or not.
    - using: Used for disposing objects (implements IDisposable), e.g., File, Stream.
    - Custom Exception: Define your own exception for domain-specific rules.

    Why:
    - Prevents app from crashing abruptly.
    - Gives user-friendly error messages.
    - Ensures cleanup of resources like file, DB, network.
    - Centralized error logging and reporting.

    When:
    - Use try-catch when external systems are involved (file, network, API, DB).
    - Use finally for guaranteed cleanup (close file, release connection).
    - Use using for auto-disposal of unmanaged resources.
    - Use custom exception to enforce business rules (e.g., "Age must be > 18").

    Interview Insight:
    - Catch most specific exceptions first (e.g., FileNotFoundException before Exception).
    - Avoid catching Exception just to hide error.
    - Don't leave empty catch blocks.
    - Always log exceptions in production.
    */

    public static class Day04_ExceptionHandling
    {
        public static void Run()
        {
            Console.WriteLine("Day 4 - Exception Handling examples\n");

            // Example 1: Simple try-catch
            try
            {

                Console.Write("Enter a number: ");
                int x = int.Parse(Console.ReadLine()?? "0"); // Default to 0 if null
                Console.WriteLine("You entered: " + x);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid number format. Please enter a valid integer.");
                Console.WriteLine("Error details: " + ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("No input received.");
                Console.WriteLine("Details: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }


// --- Version 2: int.TryParse() safe input parsing ---
            Console.Write("Enter a number: ");
            string? input = Console.ReadLine();
            //for Production Env. Safe Input Always Use TryParse
            if (int.TryParse(input, out int Y))
            {
                Console.WriteLine("You entered: " + Y);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            /*
            Notes:
            - TryParse returns false, never throws exception
            - Always use for user input in production
            - Clean, safe, avoids unnecessary try-catch
            */

            // Example 2: try-catch-finally
            try
            {
                Console.WriteLine("\nOpening file...");
                string content = File.ReadAllText("non_existing_file.txt"); // File not found
                Console.WriteLine("File Content:\n" + content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found. Please check the filename.");
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed (e.g., close file, cleanup)");
            }

            // Example 3: Using block (with FileStream)
            try
            {
                Console.WriteLine("\nReading file with 'using'...");
                using (var reader = new StreamReader("sample.txt"))
                {
                    string data = reader.ReadToEnd();
                    Console.WriteLine("Data: " + data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }

            // Example 4: Throwing custom exception
            try
            {
                Console.WriteLine("\nValidating age...");
                ValidateAge(15); // Invalid case
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("Custom exception caught: " + ex.Message);
            }
        }

        // Custom business rule
        private static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Age must be 18 or older.");
            }
            Console.WriteLine("Valid age: " + age);
        }

        // Custom exception class
        public class InvalidAgeException : Exception
        {
            public InvalidAgeException(string message) : base(message) { }
        }
    }
}


/*
Notes:
- int.TryParse() never throws exception
- Returns false if input is null or not a valid integer
- Safe for user-facing apps to prevent crash

When to use:
- Always in production or user input scenarios
- Prevents performance cost of exceptions

Interview Tip:
- Mention that TryParse is preferred over Parse for safety and performance
- Parse is useful when you know input is guaranteed clean
*/