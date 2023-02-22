# 03 Object-Oriented Programming

1.  What are the six combinations of access modifier keywords and what do they do?
    -   `public`: Accessible by entire program.
    -   `protected`: Accessible within the current class, and its derived types.
    -   `private`: Only accessible within the current class.
    -   `internal` (private internal): Accessible within the current class, current assembly, and derived types in current assembly.
    -   `protected internal`: Accessible within the current class, current assembly, derived types in current assembly, and derived types in other assemblies.
    -   `private protected`: Accessible within the current class and derived types in current assembly.
2.  What is the difference between the static, const, and readonly keywords when applied to a type member?
    -   `static`: This member belongs to its class, rather than to any particular instance of the class. It can be accessed using the type name and doesn't require an instance of the type to be created. A static member can be a field, a property, a method, or events.
    -   `const`: This member is a compile-time constant. A `const` member must be assigned a value when it is declared, and that value must be a constant expression. After that, this value can only be read and cannot be reset. A const member can only be a field and is implicitly `static` and `public`.
    -   `readonly`:  Similar to `const` fields, only that it's value's computed during runtime. It can be a field, and have access modifier. Since it's computed during runtime, it can be reference types.
3.  What does a constructor do?

    A Constructor is used to create an object of the class and initialize class members
4.  Why is the partial keyword useful?

    `partial` keyword is used to split a class, method definition in multiple parts within the same namespace, assembly, or module across multiple files.
5.  What is a tuple?

    Tuple is a lightweight datatype, where you can combine related values in one data, without the need of creating a new class.
6.  What does the C# record keyword do?

    A record is a concise way to define classes that are primarily used to store data. A record is a type of class that is immutable by default, which means that its properties cannot be modified after it is created. **When defining a class using the ****`record`**** keyword, the compiler automatically generates a constructor, a getter methods for each properties, the ****`Equals`**** and ****`GetHashCode`**** methods to compare records for equality, and A ****`ToString`**** method that returns a string representation of the record.**
7.  What does overloading and overriding mean?
    -   Overloading: Same function name, but different signatures (compiling stage polymorphism)
    -   Overriding: Same function name and signatures, but different implementation among parent and inherited classes (runtime polymorphism)
8.  What is the difference between a field and a property?
    -   A field is a variable that's declared as part of a class, and is used to store data that is associated with an instance of the class. Usually it's set private, and only accessible within the class, and they're accessed directly.
    -   A property is a special kind of member functions that provide access to a private field or some computed values, using a method-like syntax, with a get and/or set accessor.
9.  How do you make a method parameter optional?

    We can make a method parameter optional by specifying a default value for the parameter in the method signature.&#x20;
10. What is an interface and how is it different from abstract class?

    Interface is a type that defines a contract of behavior or functionality that a class can implement. It doesn't provide any details or implementations. Also interface is abstract, but it's different from abstract classes. Abstract classes can also have implemented functions.
11. What accessibility level are members of an interface?

    All members of an interface are implicitly public and cannot have any other access modifiers.
12. True/False. Polymorphism allows derived classes to provide different implementations of the same method. `T`
13. True/False. The override keyword is used to indicate that a method in a derived class is providing its own implementation of a method. `T`
14. True/False. The new keyword is used to indicate that a method in a derived class is providing its own implementation of a method. `F`
15. True/False. Abstract methods can be used in a normal (non-abstract) class. `F`
16. True/False. Normal (non-abstract) methods can be used in an abstract class. `T`
17. True/False. Derived classes can override methods that were virtual in the base class. `T`
18. True/False. Derived classes can override methods that were abstract in the base class. `T`
19. True/False. In a derived class, you can override a method that was neither virtual non abstract in the base class. `F`
20. True/False. A class that implements an interface does not have to provide an implementation for all of the members of the interface. `F`
21. True/False. A class that implements an interface is allowed to have other members that aren’t defined in the interface. `T`
22. True/False. A class can have more than one base class. `F`
23. True/False. A class can implement more than one interface. `T`

## Working with methods

1.  Coding:
    ```c#
    class LearnCSharp
    {
        static int [] GenerateNumbers(int count = 10) {
            int [] numbers = new int[count];
            for (int i = 0; i < numbers.Length; i++) {
                numbers[i] = i + 1;
            }
            return numbers;
        }
        
        static void Reverse(int [] numbers) {
            int half = numbers.Length / 2;
            int last = numbers.Length - 1;
            for (int i = 0; i < half; i++) {
                int temp = numbers[i];
                numbers[i] = numbers[last - i];
                numbers[last - i] = temp;
            }
        }
        
        static void PrintNumbers(int [] numbers) {
            Console.WriteLine(string.Join(", ", numbers));
        }
        
        static void Main(string[] args) {
            int[] numbers = GenerateNumbers();
            Reverse(numbers);
            PrintNumbers(numbers);
        }
    }
    ```
2.  Coding:
    ```c#
    class FibonacciHelper
    {
        private List<int> fibonacci_cache = new List<int>();
        
        public FibonacciHelper()
        {
            fibonacci_cache.Add(0);
            fibonacci_cache.Add(1);
        }

        public int Fibonacci(int n)
        {
            if (n < fibonacci_cache.Count)
                return fibonacci_cache[n];
            else
            {
                int i = fibonacci_cache.Count - 1;
                while (i < n)
                {
                    fibonacci_cache.Add(fibonacci_cache[i] + fibonacci_cache[i-1]);
                    ++i;
                }
                return fibonacci_cache[n];
            }
        }
    }

    class LearnCSharp
    {
        static void Main(string[] args)
        {
            var fib = new FibonacciHelper();
            for (int i = 1; i <= 30; ++i)
            {
                Console.Write($"{fib.Fibonacci(i)} ");
            }
        }
    }
    ```
