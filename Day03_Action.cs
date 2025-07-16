using System;
using System.Collections.Generic;

namespace PracticePrograms
{
    /*
    Topic: Action<T> Delegate

    What
      Action<T> is a built-in delegate that represents a method
      which returns void and accepts zero or more parameters.

    Why
      Useful when you want to pass a behavior (method) that does
      something (like logging, printing, UI update) but doesn’t return a value.

    When
      – For side-effects like writing to console, logging, updating UI.
      – When injecting callback functions into frameworks or custom workflows.
      – When working with LINQ's ForEach or Task-based logic.

    How
      Action:        () => void
      Action<T>:     (T) => void
      Action<T1,T2>: (T1,T2) => void, up to 16 parameters supported.
    */

    public static class Day03_Action
    {
        public static void Run()
        {
            Console.WriteLine("Day 3 - Action<T> examples\n");

            // Example 1: Action with no parameter
            Action sayHello = () => Console.WriteLine("Hello from Action!");
            sayHello();

            // Example 2: Action with one parameter
            Action<string> greet = name => Console.WriteLine($"Welcome, {name}!");
            greet("Rohan");

            // Example 3: Action with two parameters
            Action<string, int> showAge = (name, age) =>
                Console.WriteLine($"{name} is {age} years old.");
            showAge("Gatha", 4);

            // Example 4: Using Action in List.ForEach
            var items = new List<string> { "One", "Two", "Three" };
            items.ForEach(item => Console.WriteLine($"Item: {item}"));

            /*
            Real-world analogy
              Think of Action<T> as giving someone a task to perform.
              You don’t care what result comes back — you only care the task is done.

            Interview insight
              – Action<T> always returns void.
              – Common in event handlers, logging frameworks, UI actions.
              – Use when you want to invoke logic without expecting a result.

            Best practices
              – Use clear, meaningful variable names for Actions.
              – Keep logic focused on side-effects only.
              – Avoid heavy business logic inside Action lambdas.
            */
        }
    }
}
