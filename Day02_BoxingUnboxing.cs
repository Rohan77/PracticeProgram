using System;

namespace PracticePrograms
{
    public static class Day02_BoxingUnboxing
    {
        public static void Run()
        {
            Console.WriteLine("Day 2 – Boxing and Unboxing\n");

            object boxed = 42; // boxing
            int unboxed = (int)boxed; // unboxing

            Console.WriteLine($"Boxed value: {boxed}");
            Console.WriteLine($"Unboxed value: {unboxed}");

        }

    }

}
//Notes:
 /*
            What is Boxing?

            - Boxing is the process of converting a **value type (int, float, etc.)**
              into an **object** (reference type).
            - Internally, it creates a new object on the heap and copies the value type data there.

            Why is Boxing required?

            - When you're storing value types in a data structure that only accepts objects,
              like ArrayList (pre-generic days), or passing to methods expecting object.

            Example:
                int num = 10;
                object obj = num; // Boxing happens here

            What's the downside?

            - Performance! Boxing allocates memory on the heap → increases GC pressure.
            - Also causes type-safety loss: you don't get compile-time checking.

            ---------------------------------------------------

            What is Unboxing?

            - Unboxing is the reverse: converting an **object back to value type**.
            - You must explicitly cast the object to its original value type.

            Example:
                object obj = 42;     // boxed
                int x = (int)obj;    // unboxing

            Risks in Unboxing?

            - If you unbox to wrong type → runtime InvalidCastException
            - Also involves performance overhead

            ---------------------------------------------------

            Real-world Example (Before Generics):
                ArrayList list = new ArrayList();
                list.Add(100); // boxing
                int val = (int)list[0]; // unboxing

            After Generics (No boxing/unboxing):
                List<int> list = new List<int>();
                list.Add(100); // no boxing
                int val = list[0]; // no unboxing

            Summary:

            - Boxing/unboxing is **implicit+explicit type conversion** between value type ↔ object.
            - Avoid it where possible — prefer generics, type-safe collections, and structs only when necessary.
            - Know this deeply for performance-critical applications.

            Pro
*/