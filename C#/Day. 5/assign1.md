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

   

3. What is meant by the terms managed resource and unmanaged resource in .NET

   

4. Whats the purpose of Garbage Collector in .NET?

   