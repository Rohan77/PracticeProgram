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