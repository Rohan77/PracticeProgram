using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticePrograms
{
    /*
    Topic: LINQ Advanced

    What:
    - LINQ advanced features provide powerful data shaping and analysis tools:
        - GroupBy → categorizing data
        - Join → combining related collections
        - SelectMany → flattening nested collections
        - Any / All → predicate-based checks
        - Distinct / Intersect / Except → set operations

    Why:
    - Helps build complex queries in readable form
    - Reduces manual loops and nested conditionals

    When:
    - Whenever you work with related datasets (e.g., parent-child), or require group-wise aggregations, joins, or flattening

    Interview Notes:
    - GroupBy returns IGrouping<TKey, T>
    - Join requires a common key
    - SelectMany flattens collections like List<List<T>> → List<T>
    - Any = is there at least one match?  All = do all match?

    Best Practices:
    - Always filter before projecting (Where before Select)
    - Use anonymous types in joins when full object not required
    */

    public static class Day04_LINQAdvanced
    {
        public static void Run()
        {
            Console.WriteLine("Day 4 - LINQ Advanced Examples\n");

            // Sample employee and department data
            var departments = new List<Department>
            {
                new Department { Id = 1, Name = "HR" },
                new Department { Id = 2, Name = "IT" },
                new Department { Id = 3, Name = "Finance" }
            };

            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Amit", DepartmentId = 1, Skills = new List<string>{ "Excel", "Communication" } },
                new Employee { Id = 2, Name = "Rohan", DepartmentId = 2, Skills = new List<string>{ "C#", "SQL" } },
                new Employee { Id = 3, Name = "Sneha", DepartmentId = 2, Skills = new List<string>{ "Angular", "C#", "Azure" } },
                new Employee { Id = 4, Name = "Meera", DepartmentId = 3, Skills = new List<string>{ "Tally" } },
                new Employee { Id = 5, Name = "John", DepartmentId = 2, Skills = new List<string>{ "React", "NodeJS" } }
            };

            // 1. GroupBy: Employees per department
            var grouped = employees.GroupBy(e => e.DepartmentId);
            Console.WriteLine("Employees grouped by department:");
            foreach (var group in grouped)
            {
                string deptName = departments.FirstOrDefault(d => d.Id == group.Key)?.Name ?? "Unknown";
                Console.WriteLine($"Department: {deptName}");
                foreach (var emp in group)
                    Console.WriteLine($" - {emp.Name}");
            }

            // 2. Join: Employees with department names
            var joined = employees.Join(
                departments,
                emp => emp.DepartmentId,
                dept => dept.Id,
                (emp, dept) => new { emp.Name, Department = dept.Name }
            );

            Console.WriteLine("\nEmployees with department names:");
            foreach (var item in joined)
                Console.WriteLine($"{item.Name} - {item.Department}");

            // 3. SelectMany: All unique skills from all employees
            var allSkills = employees.SelectMany(e => e.Skills).Distinct();
            Console.WriteLine("\nAll unique skills:");
            foreach (var skill in allSkills)
                Console.WriteLine("- " + skill);

            // 4. Any: Check if any employee knows Angular
            bool hasAngular = employees.Any(e => e.Skills.Contains("Angular"));
            Console.WriteLine($"\nAnyone with Angular? {hasAngular}");

            // 5. All: Do all employees have at least one skill?
            bool allSkilled = employees.All(e => e.Skills.Any());
            Console.WriteLine($"Everyone has skills? {allSkilled}");

            // 6. Set Operation: Who knows C# but not Angular?
            var csharpPeople = employees.Where(e => e.Skills.Contains("C#")).Select(e => e.Name);
            var angularPeople = employees.Where(e => e.Skills.Contains("Angular")).Select(e => e.Name);
            var onlyCSharp = csharpPeople.Except(angularPeople);

            Console.WriteLine("\nPeople with C# but not Angular:");
            foreach (var name in onlyCSharp)
                Console.WriteLine(name);
        }

        class Department
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
        }

        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public int DepartmentId { get; set; }
            public List<string> Skills { get; set; } = new List<string>();
        }
    }
}
