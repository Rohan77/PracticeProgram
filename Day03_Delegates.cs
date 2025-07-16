using System;

namespace PracticePrograms
{
    // Step 1: Define a delegate signature
    public delegate void MyPrinter(string message);

    public class Printer
    {
        // Step 2: Method that matches delegate signature
        public void PrintToConsole(string msg)
        {
            Console.WriteLine($"Console: {msg}");
        }

        public void PrintToFile(string msg)
        {
            Console.WriteLine($"File: {msg} (pretend written to file)");
        }
    }

    public static class Day03_Delegates
    {
        public static void Run()
        {
            Console.WriteLine("Day 3 - Delegates, Events, Func/Action/Predicate");
            Console.WriteLine();

            Printer printer = new Printer();

            // Step 3: Assign method to delegate
            MyPrinter printDelegate = printer.PrintToConsole;
            printDelegate("Hello from delegate!");

            // Step 4: Multicast delegate (+=)
            printDelegate += printer.PrintToFile;
            printDelegate("Now printing to both!");

            /*
            🔹 Delegates are type-safe function pointers.
            🔹 They allow methods to be passed as parameters.
            🔹 Useful in callbacks, plugin-style architecture.

            Real-time example:
            - Logging: Pass delegate to decide how/where to log (file, DB, UI)
            - Strategy pattern: Swap logic at runtime using delegates

            Interview Tip:
            - Delegate supports multicasting
            - Can hold reference to static or instance methods
            - Built-in delegates = Func, Action, Predicate


What
    A delegate is a type-safe object that can hold a reference to a method with a specific signature.
    It allows methods to be passed as parameters, assigned to variables, and invoked dynamically.
    Think of it as a function pointer with type safety.

Why
    To implement callback mechanisms — calling a method without knowing the method in advance.
    To support plug-and-play behavior — pass methods into logic blocks.
    Foundation for Events, LINQ, and functional-style programming in C#.

When
    When you want to decouple logic by allowing caller to inject method.
    When building framework-style components, e.g., logging, filtering, command execution.
    When you want to execute dynamic behavior without hardcoding logic.

Real-World Analogy
    Like giving someone a phone number to call — you don’t know who will pick up, but you trust the number connects to someone who’ll handle the message correctly.
    Delegate is the number, method is the receiver.

Best Practices
    Use delegates when method needs to be dynamically injected or executed.
    Prefer Func<> / Action<> if you don’t need to declare your own delegate type.
    Use event keyword if delegate is meant for notification pattern (e.g., button click).
    Keep delegate signatures simple and focused — avoid mixing unrelated parameters.


Delegate Types
    Action → No return value
    Action<int> → method with one int parameter, returns void
    Func → Has return value
    Func<int, string> → method taking int, returning string
    Predicate<T> → Returns bool
    Predicate<string> → takes string, returns true/false

 */
        }
    }
}
