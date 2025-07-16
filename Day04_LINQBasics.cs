using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticePrograms
{
    /*
    Topic: LINQ Basics (Language Integrated Query)

    What:
    - LINQ = query-like syntax to work with collections (List, Array, DB, XML etc.)
    - LINQ provides methods like Where, Select, OrderBy, GroupBy, etc.
    - Works with in-memory collections using IEnumerable<T> and IQueryable<T>

    Why:
    - Clean, readable, declarative style for filtering, transforming, grouping, and aggregating data
    - Replaces complex for/foreach loops with concise expressions
    - Same syntax for SQL, XML, collections, etc.

    When:
    - Use LINQ when working with lists/arrays to perform filtering, transformation, aggregation
    - Widely used in DB queries via LINQ to SQL / Entity Framework

    Real-World Analogy:
    - Like writing SQL over List<T> or Array (e.g., "SELECT name WHERE age > 18")

    Interview Notes:
    - LINQ is lazy (executes when iterated)
    - Use `ToList()` to force execution
    - Two syntaxes: Query Syntax and Method Syntax (use Method Syntax in interviews)
    */

    public static class Day04_LINQBasics
    {
        public static void Run()
        {
            Console.WriteLine("Day 4 - LINQ Basics Examples\n");

            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Amit", Age = 30, Salary = 60000 },
                new Employee { Id = 2, Name = "Rohan", Age = 24, Salary = 45000 },
                new Employee { Id = 3, Name = "Sneha", Age = 29, Salary = 75000 },
                new Employee { Id = 4, Name = "John", Age = 35, Salary = 55000 },
                new Employee { Id = 5, Name = "Meera", Age = 22, Salary = 40000 }
            };

            // Example 1: Filter (Where)
            var filtered = employees.Where(e => e.Age > 25);
            Console.WriteLine("Employees age > 25:");
            foreach (var e in filtered)
                Console.WriteLine($"- {e.Name}, Age: {e.Age}");

            // Example 2: Projection (Select)
            var names = employees.Select(e => e.Name).ToList();
            Console.WriteLine("\nAll employee names:");
            names.ForEach(name => Console.WriteLine("- " + name));

            // Example 3: Ordering
            var sorted = employees.OrderByDescending(e => e.Salary);
            Console.WriteLine("\nEmployees sorted by salary (desc):");
            foreach (var e in sorted)
                Console.WriteLine($"{e.Name} - {e.Salary}");

            // Example 4: Aggregation (Count, Average)
            int count = employees.Count();
            double avgSalary = employees.Average(e => e.Salary);
            Console.WriteLine($"\nTotal employees: {count}, Average salary: {avgSalary}");

            // Example 5: FirstOrDefault
            var highEarner = employees.FirstOrDefault(e => e.Salary > 70000);
            Console.WriteLine($"\nFirst employee earning > 70k: {highEarner?.Name}");

            /*
            Best Practices:
            - Prefer Method Syntax over Query Syntax in interviews
            - Use chaining of LINQ operations (Where().Select().ToList())
            - Avoid .ToList() if not required — keeps it lazy
            - Use FirstOrDefault for safe fetching
            - Don't forget null checks when using First/FirstOrDefault/Single
            */
        }

        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public int Age { get; set; }
            public double Salary { get; set; }
        }
    }
}
