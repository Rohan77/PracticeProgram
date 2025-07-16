using System;
using System.Threading;
using System.Threading.Tasks;

namespace PracticePrograms
{
    
    /*
Topic: Thread vs Task vs async/await

What:
-------
1. Thread:
   - A low-level OS-managed unit of execution.
   - Manual control: you start, pause, and terminate threads.
   - Costly in terms of memory (~1MB per thread) and CPU (context switching).
   - Example: Thread t = new Thread(() => { ... }); t.Start();

2. Task:
   - A higher-level abstraction introduced in TPL (Task Parallel Library).
   - Represents a unit of asynchronous or concurrent work.
   - Uses thread pool internally (no new OS threads unless needed).
   - Scalable and preferred for background jobs, parallelism.
   - Example: Task.Run(() => { ... });

3. async/await:
   - Language features that enable **non-blocking** asynchronous code.
   - `async` marks a method as asynchronous.
   - `await` tells compiler to pause and resume code execution later.
   - Behind the scenes, compiler rewrites the method as a state machine.
   - Works best with I/O-bound operations (API, DB, file access).
   - Example: await Task.Delay(1000);

Why:
-----
- Thread gives manual control but is heavyweight. Avoid unless necessary.
- Task provides parallelism and offloading with better performance.
- async/await improves readability of async code and avoids callback hell.

When to use:
-------------
- Use Thread for long-running, tightly controlled background processes (rare).
- Use Task for parallel loops, CPU-intensive operations, and offloading logic.
- Use async/await for I/O-bound workflows like:
    - HTTP calls
    - File access
    - DB access
    - Timer delays (await Task.Delay)

Real-world analogy:
---------------------
- Thread: Hiring a dedicated full-time worker to do one job.
- Task: Giving a task to a freelancer who picks it from a shared job pool.
- async/await: Assigning a task and saying "notify me when it's done" (you don't wait idly).

Best Practices:
----------------
- Prefer async/await for I/O-bound work (non-blocking, clean code).
- Avoid `Thread.Sleep` inside async methods — use `await Task.Delay`.
- Avoid `.Result`, `.Wait()` — they block threads and can deadlock.
- Always return Task or Task<T> from async methods (never void).
- Use ConfigureAwait(false) in libraries to prevent deadlocks (UI independence).
- For compute-bound work, use Task.Run(() => ...).

Interview Points:
------------------
- Thread vs Task: Task uses thread pool; thread is new OS thread.
- async/await doesn't create threads — it just rewrites method into resumable steps.
- await is non-blocking, it returns control to the caller.
- async methods that return void are only for event handlers.
- Deadlocks happen when you use `.Result` or `.Wait()` on an async call on the main thread (esp. in UI apps).
- Prefer `await Task.WhenAll(...)` for parallel async calls.

Common Mistakes:
------------------
- Mixing synchronous and asynchronous code.
- Not handling exceptions in async methods (use try-catch inside async).
- Not awaiting tasks (leads to unobserved task exceptions).
- Blocking UI thread with `.Result` or `.Wait()`.

*/

    public static class Day04_Async
    {
        public static void Run()
        {
            Console.WriteLine("Day 4 - Task vs Thread vs async/await examples\n");

            // Example 1: Using Thread
            Console.WriteLine("1. Starting manual Thread...");
            Thread thread = new Thread(() =>
            {
                Thread.Sleep(2000); // blocks the thread
                Console.WriteLine("Thread work done");
            });
            thread.Start();

            // Example 2: Using Task without await (fire and forget)
            Console.WriteLine("2. Starting Task.Run without await...");
            Task.Run(() =>
            {
                Thread.Sleep(1000); // also blocks the worker thread
                Console.WriteLine("Task.Run work done");
            });

            // Example 3: Using async/await properly
            Console.WriteLine("3. Running async/await method...");
            RunAsyncMethod().Wait();  // Just for demo; normally avoid .Wait()

            Console.WriteLine("\nMain method finished\n");
        }

        private static async Task RunAsyncMethod()
        {
            Console.WriteLine("Inside async method — waiting 2s using Task.Delay...");
            await Task.Delay(2000); // non-blocking wait
            Console.WriteLine("Async method resumed after await.");
        }
    }
}
/*
Code Explanation:

// 1. Thread
- We created a manual thread using: new Thread(() => { ... });
- Inside it, we called Thread.Sleep(2000) → this blocks the thread for 2 seconds.
- After 2 seconds, the thread prints "Thread work done".
- Use case: When you want precise control over thread lifecycle. But expensive.

// 2. Task without await (fire and forget)
- Task.Run creates a background task using thread pool.
- Thread.Sleep(1000) again blocks, but only the internal thread — not main.
- This is a fire-and-forget pattern (you don't wait for result).
- Use case: When you want to do some background work and don’t need result.

// 3. async/await method
- The RunAsyncMethod is marked `async` and uses `await Task.Delay(2000)`.
- This is **non-blocking** — main thread gets control back immediately.
- After 2 seconds, async resumes execution and prints "Async work done".
- Use case: Perfect for I/O-bound operations like API/db/file access.

Important Points:
- Thread blocks → expensive.
- Task can be awaited or run independently.
- async/await → cleaner, readable async logic without blocking.
- Prefer Task.Delay over Thread.Sleep in async code.

Why `.Wait()` is used in demo:
- Normally avoid `.Wait()` in async code. Here we used it in `Run()` just to wait for the async method to complete in a console app 
(which doesn’t support async `Main()` in older .NET versions).

Production code should use:
```csharp
static async Task Main(string[] args)
{
    await Day04_Async.RunAsync();
}

Interview Tip:

    When someone says "What’s the difference between Task and Thread?"
    → Task = abstraction, pooled, scalable.
    → Thread = manual, resource-heavy, low-level.

    And “Why async/await?” → Makes async code easy to read and maintain. You don't block threads, you yield control.
*/