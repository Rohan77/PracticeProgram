# PracticePrograms

Console-based C# learning project — daily interview preparation for experienced .NET developers.
[1] It Contains Program
[2] Detailed Notes On Each Topic, Including When, Why, And How To Use The Concept, Along With Best Practices And Real-Life Analogies

---

## Structure

```
PracticePrograms/
├── Program.cs // Dynamic menu (dictionary-based)
├── Day01_ValueVsReference.cs
├── Day02_BoxingUnboxing.cs
├── Day02_OOP_ClassObject.cs
├── Day02_OOP_Inheritance.cs
├── Day02_OOP_Polymorphism.cs
├── Day02_OOP_Abstraction.cs
├── Day02_OOP_Interface.cs
├── Day02_OOP_Encapsulation.cs
├── Day02_OOP_StaticVsInstance.cs
├── Day02_OOP_Constructors.cs
├── Day02_OOP_IsA_HasA.cs
├── Day03_Delegates.cs
├── Day03_Events.cs
├── Day03_Func.cs
├── Day03_Action.cs
├── Day03_Predicate.cs
├── push.ps1 // Git auto-push script
├── PracticePrograms.csproj
└── .gitignore
```

---

## 🚀 Build & Run

```bash
dotnet run

The app will show a menu with all available day-wise examples. Select a number to run the corresponding example.

✅ Completed Topics
        Day 1 – C# Basics

            Value Types vs Reference Types

            Boxing and Unboxing

        Day 2 – OOP Concepts

            Class & Object

            Inheritance

            Polymorphism

            Abstraction

            Interface

            Encapsulation

            Static vs Instance

            Constructor Types

            IS-A vs HAS-A (Inheritance vs Composition)

        Day 3 – Delegates & Events

            Delegates

            Events

            Func<T>

            Action<T>

            Predicate<T>

        🧠 How to Add a New Example

        1. Create a file DayXX_TopicName.cs in the PracticePrograms folder.

        2. Use a static class with a public static void Run() method.

        3. Add a new entry to the Topics dictionary in Program.cs:


        ⚙️ Using push.ps1

        The push.ps1 file automates git add, commit, and push operations.
        🛠️ How to run it (once permissions are set):
        pwsh ./push.ps1


Happy coding! ✨