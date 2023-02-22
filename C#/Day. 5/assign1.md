1. What type would you choose for the following “numbers”?

   - A person’s telephone number: 
     - `string`, because phone numbers contains region areas, country code, and other characters, not only numbers. 
   - A person’s height: `float`.
   - A person’s age: `byte`. Since no one will have age > 150, so 0-255 is enough to store this.
   - A person’s gender (Male, Female, Prefer Not To Answer): `enum`.
   - A person’s salary: `decimal` for money type.
   - A book’s ISBN: `string`
   - A book’s price: `decimal` for money type.
   - A book’s shipping weight: `double`.
   - A country’s population: `ulong`, since population won't handle negative numbers.
   - The number of stars in the universe: `BigInteger`
   - The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business): `ushort`. (0 - 65535). Considering the possibility of exceeding this limit in the future and to enhance scalability, a `uint` can be used.

2. What are the difference between value type and reference type variables? What is boxing and unboxing?

   - **Value Type** directly **contain their data**, and when you copy the value type using assign operator (=), each has its own copy of data. If you want to force the referencing, you have to explicitly add `ref` keyword in the parameter of a function. Value Type is not managed by GC.

   - For reference type, it **stores a pointer to their data in the Heap in memory**. When using (=), you're copying two reference variable pointing to the same object. Operation on one can effect another.

   - Boxing and Unboxing are mechanisms in C# for converting values types to reference types, and vice versa. 

     Boxing: `int value = 1; object objValue = value; `

     Unboxing: `object boxedVal = 2; int value = (int)boxedVal;`

3. What is meant by the terms managed resource and unmanaged resource in .NET

   Managed resource is resources that created and collected by garbage collector automatically. Unmanaged resource is what cannot be maintained by GC. For example, an internet connection resource, a sql connection resource, all are resoures not managed by GC.

4. Whats the purpose of Garbage Collector in .NET?

   GC is a component in CLR that manage allocation and deallocation of memory used by .NET applications. Its purpose is to free up memory that is no longer being used by an application, so that it can be reused by other parts of the application or by other applications running on the system.

## Practice number sizes and ranges

See `UnderstandingTypes/`.

## Controlling Flow and Converting Types

1. What happens when you divide an int variable by 0?

   Get exception: `System.DivideByZeroException`.
2. What happens when you divide a double variable by 0?

   Get Infinity.
3. What happens when you overflow an int variable, that is, set it to a value beyond its range?

   This will happen what like in C language, the number will overflow. Such as for Int32, if number exceed 2147483647, it will become -2147483648.

   If we want to capture this underlying problems, we can use `checked` keyword:

   ```C#
   int num = int.MaxValue;
   checked
   {
       num = num + 1; 
   }
   ```

   Then this will cause an overflow and throw an exception. However, it is not always a good thing to use `checked` all the time, as it can increase CPU overhead. Therefore, `checked` should only be used when the program needs to consider the risks of overflow in its business logic.
4. What is the difference between x = y++; and x = ++y;?

   - `y++`: first set x = y's old value, then self-increment y.
   - `++y`: first self-increment y, then set x = y's new value.
5. What is the difference between break, continue, and return when used inside a loop statement?

   - `break`: directly exit the nearest loop frame, stopping the loop.
   - `continue`: skips the remaining code within the loop, proceeds to the next iteration.
   - `return`: exits the function and returns a value, stopping the loop and any further processing within the function.
6. What are the three parts of a for statement and which of them are required?

   for (**Declare Variables and initival values**; **End Conditions**; **Step Part (Self-increment/Self-Decrement)**).

   **Only End Part is required.** If we omit the initialization and increment parts of the `for` loop, it will degrade to a `while` loop.

7. What is the difference between the = and == operators?

   - `=` is assignment statement.
   - `==` is compare statement.

8. Does the following statement compile? `for ( ; true; ) ;`

   Yes. It's identical to:

   ```C#
   while (true) {
     // do some stuffs.
   }
   ```

9. What does the underscore _ represent in a switch expression?

   It's a new C# 8.0 language feature, using an underscore (`_`) as a case label is similar to using the `default` keyword in the traditional switch.`default` keyword can only be used as the last case label in a traditional `switch` statement, while the underscore can be used as any case label in a C# 8.0 switch expression.

10. What interface must an object implement to be enumerated over by using the foreach statement?

    In C#, an object must implement the `IEnumerable` or `IEnumerable<T>` interface to be enumerated over by using the `foreach` statement.


## Practice Loops and Operators

See `Chapter03/`.   

1. What does this happen?

   ```C#
   int max = 500;
   for (byte i = 0; i < max; ++i)
   {
       Console.WriteLine(i);
   }
   ```

   Because byte up tp 255, so this program will loop forever, print from 0 to 255, and repeat. It won't end since byte cannot reach 500.

   
