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

