using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticePrograms
{
    /*
    Topic: LINQ Query Syntax vs Method Syntax

    What:
    - LINQ provides two styles to write queries over collections:
      1. Query Syntax: SQL-like syntax (from x in y select x)
      2. Method Syntax: Method chaining (x.Where().Select())

    Why:
    - Provides clean and concise way to filter, transform, and aggregate collections
    - Makes code more declarative, readable, and easier to reason about

    When:
    - Use Query Syntax for simpler filtering and selection
    - Use Method Syntax when doing advanced operations (Join, GroupBy, SelectMany)

    How:
    - Query syntax works best for basic select/where/orderby
    - Method syntax works best for most real-world and complex scenarios

    Benefits:
    - Eliminates manual for/foreach loops
    - Same LINQ syntax works on arrays, List<T>, XML, EF Core, DB sets
    - Declarative style separates what to do from how to do
    - Encourages functional, composable design

    Interview Tip:
    - Method syntax is more powerful and preferred in professional environments
    - Be fluent with Method Syntax: Where, Select, SelectMany, GroupBy, Any, All, Join
    */

    public static class Day04_LINQComparison
    {
        public static void Run()
        {
            Console.WriteLine("Day 4 - LINQ Query vs Method Syntax Comparison\n");

            int[] numbers = { 3, 6, 1, 4, 8, 5, 2 };

            // --- Query Syntax Example ---
            var querySyntax = from n in numbers
                              where n > 4
                              orderby n
                              select n;

            Console.WriteLine("Query Syntax - Numbers > 4:");
            foreach (var n in querySyntax)
                Console.WriteLine(n);

            /*
            Notes:
            - Query syntax is useful for basic filtering and ordering
            - Looks like SQL; beginner-friendly
            - Cannot express complex queries like SelectMany, Aggregate, Join (easily)
            */

            // --- Method Syntax Example ---
            var methodSyntax = numbers
                                .Where(n => n > 4)
                                .OrderBy(n => n)
                                .Select(n => n);

            Console.WriteLine("\nMethod Syntax - Numbers > 4:");
            foreach (var n in methodSyntax)
                Console.WriteLine(n);

            /*
            Notes:
            - Method syntax is more expressive and chainable
            - Supports complete LINQ operations (GroupBy, Join, SelectMany, etc.)
            - Preferred in professional projects and EF Core
            */

            // Bonus: Complex method syntax (SelectMany)
            var departments = new[]
            {
                new { Name = "IT", Skills = new[] { "C#", "SQL" } },
                new { Name = "HR", Skills = new[] { "Excel", "PeopleMgmt" } }
            };

            var allSkills = departments.SelectMany(d => d.Skills).Distinct();

            Console.WriteLine("\nAll unique skills from all departments:");
            foreach (var skill in allSkills)
                Console.WriteLine("- " + skill);
        }
    }
}
