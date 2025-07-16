using System;
using System.Collections.Generic;

namespace PracticePrograms
{
    /*
    Topic: Predicate<T> Delegate

    What
      Predicate<T> is a built-in delegate that represents a method
      taking one parameter of type T and returning a bool (true/false).
      Equivalent to: Func<T, bool>

    Why
      Used for filtering collections, checking match conditions, or
      finding items in lists (List<T>.Find, Exists, RemoveAll etc.)

    When
      – When evaluating a yes/no condition on a single object.
      – In filtering logic or decision-making algorithms.
      – In collection methods like Find(), Exists(), RemoveAll(), etc.

    How
      Predicate<T> pred = methodThatReturnsBool;
      List<T>.Find(pred), List<T>.RemoveAll(pred), etc.
    */

    public static class Day03_Predicate
    {
        public static void Run()
        {
            Console.WriteLine("Day 3 - Predicate<T> examples\n");

            // Example 1: Predicate on string to check if length > 5
            Predicate<string> longWord = word => word.Length > 5;
            Console.WriteLine($"Is 'Elephant' a long word? {longWord("Elephant")}");

            // Example 2: Using Predicate in List<T>.Find
            List<int> numbers = new List<int> { 1, 2, 4, 7, 9 };
            Predicate<int> isEven = x => x % 2 == 0;
            int firstEven = numbers.Find(isEven);
            Console.WriteLine($"First even number: {firstEven}");

            // Example 3: Using Predicate in List<T>.RemoveAll
            Predicate<int> isOdd = x => x % 2 != 0;
            numbers.RemoveAll(isOdd);
            Console.WriteLine("After removing odds: " + string.Join(", ", numbers));

            /*
            Real-world analogy
              Predicate is like asking a true/false question about each item —
              like "Is this eligible?", "Is this expired?", or "Is this match?"

            Interview insight
              – Use Predicate<T> when dealing with true/false filtering.
              – It's a shortcut for Func<T, bool> and commonly used with List<T>.
              – Makes code more readable and intention clear in filtering operations.

            Best practices
              – Keep predicate expressions short and descriptive.
              – Use with built-in methods like Find, Exists, RemoveAll, etc.
              – Prefer Predicate<T> over Func<T, bool> in collection-related APIs for clarity.
            */
        }
    }
}
