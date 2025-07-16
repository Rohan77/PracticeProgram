using System;

namespace PracticePrograms
{
    public static class Day01_ValueVsReference
    {
        public static void Run()
        {
            Console.WriteLine("Day 1 – Value vs Reference Types\n");

            // Value type example
            int a = 10;
            int b = a;
            b = 20;
            Console.WriteLine($"Value types -> a = {a}, b = {b}");

            // Reference type example
            int[] arr1 = { 1, 2 };
            int[] arr2 = arr1;
            arr2[0] = 99;
            Console.WriteLine($"Reference types -> arr1[0] = {arr1[0]}, arr2[0] = {arr2[0]}");
        }
    }
}


//Notes:
/*
Question 1: What is the difference between Value Type and Reference Type in C#?
            
            What is a Value Type?

            - A value type stores its **actual data** directly in memory where it's declared.
            - When you assign it to another variable, it makes a full **copy** of that data.

            Example:
                int a = 10;
                int b = a;
                b = 20;
                // 'a' is still 10, because 'b' got a separate copy

            Use Cases:
            - Best for lightweight, short-lived data: int, bool, float, structs
            - Value types are stored on the stack (usually), so access is faster.

            --------------------------------------------------

            What is a Reference Type?

            - Reference types store a **reference (pointer)** to actual data on the heap.
            - Assigning to another variable copies the reference, **not the object**.

            Example:
                int[] arr1 = new int[] { 1, 2, 3 };
                int[] arr2 = arr1;
                arr2[0] = 99;
                // Now arr1[0] is also 99 — because both refer to same array in memory

            Use Cases:
            - For large or complex data structures (arrays, class objects, strings)
            - Needed when you want multiple variables to refer to the same data

            --------------------------------------------------

            Deep vs Shallow Copy:

            - Value types are naturally deep-copied.
            - Reference types need special handling (like using `.Clone()` or manual copying)
              if you want deep copies — else all references point to same object.

            Practical Insight:

            - Bugs from reference types usually happen when you forget that
              assignment is by reference — and changes affect the original.
            - In multithreaded apps, reference types need more care (locking, immutability)

            Interview Summary:

            - Value types = actual value | copied on assignment
            - Reference types = memory reference | shared across assignments
            - Classes = reference type, Structs = value type


 What:
    Value types store data directly in memory (stack).
    Reference types store a reference to the data (on heap).

 Why:
    To understand how memory is managed in .NET (stack vs heap).
    To avoid unexpected behavior during assignment, parameter passing, and comparisons.
    It impacts performance, mutability, and garbage collection.
When:
    When you're working with data structures, method parameters, or optimizing memory.
    When you see unexpected behavior like one object affecting another after assignment.
    When designing APIs or libraries that need to be efficient and predictable.
    When you need to understand how C# handles data types under the hood.
    While designing DTOs, models, or writing performance-critical code.

 Real-World Analogy:
    Value Type: Like photocopying a document. You can write on your copy, original remains unchanged.
    Reference Type: Like two remotes pointing to the same TV. Change from one reflects on the other.
*/


