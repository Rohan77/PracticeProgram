using System;

namespace PracticePrograms
{
    /*
    Topic: Func<T> Delegate

    What
      Func<T> (and its generic overloads) is a built‑in delegate that
      represents a method which returns a value.  
      The last generic parameter is the return type; any preceding generic
      parameters are input arguments.

    Why
      Saves you from declaring custom delegates for common patterns.
      Enables passing business logic as a first‑class value (functional style),
      which improves reuse and decouples algorithms from data.

    When
      – Writing LINQ queries or higher‑order utility methods.  
      – Implementing strategy‑pattern style callbacks.  
      – Creating small on‑the‑fly computations without verbose delegate
        declarations.

    How  (examples below)
    */

    public static class Day03_Func
    {
        public static void Run()
        {
            Console.WriteLine("Day 3 - Func<T> examples");
            Console.WriteLine();

            // Example 1: Func<int, int, int>  (adds two numbers)
            Func<int, int, int> add = (x, y) => x + y;
            int sum = add(5, 7);
            Console.WriteLine($"Sum of 5 and 7 is {sum}");

            // Example 2: Func<string, bool>  (checks palindrome)
            Func<string, bool> isPalindrome = text =>
            {
                string rev = new string(text.ToCharArray().Reverse().ToArray());
                return text.Equals(rev, StringComparison.OrdinalIgnoreCase);
            };
            Console.WriteLine($"Is 'level' palindrome? {isPalindrome("level")}");

            // Example 3: Using Func in LINQ – mapping integers to squares
            int[] data = { 1, 2, 3, 4 };
            Func<int, int> square = n => n * n;
            var squares = data.Select(square);
            Console.WriteLine("Squares: " + string.Join(", ", squares));

            /*
            Real‑world analogy
              Think of Func<T> as a plug‑and‑play adapter:
              you supply a piece of logic (plug) that fits a standard socket
              (the delegate signature) and the framework executes it when needed.

            Interview insight
              – Func<T> always returns a value; Action<T> returns void.
              – Predicate<T> is a special case: Func<T,bool>.  
              – Ideal for composing LINQ queries and asynchronous workflows.
              – Func delegates are immutable; you assign them once and call.

            Best practices
              – Keep lambda bodies short and side‑effect free.
              – Use descriptive variable names for delegates (e.g. filter, mapper).
              – Prefer Func over custom delegate types unless a clear domain
                meaning justifies a named delegate.
            */
        }
    }
}
