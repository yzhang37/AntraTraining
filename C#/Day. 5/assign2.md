## 02 Arrays and Strings

### Test your Knowledge

1. When to use String vs. StringBuilder in C# ?
   - String is an atomic object which cannot be modified. If we want to just display a fixed string, then we should use **string**. Otherwise, if we need to modify the string very frequently, we should use **StringBuilder** such as but not limited to:
     - Use [] to modify the character in specified position.
     - Doing concatenation of string very frequently, even inside a loop. We need to concatenate a large number of strings together. 
2. What is the base class for all arrays in C#?

   `System.Arrays` is the base classes for all Arrays in C#, regardless of their element type or rank.
3. How do you sort an array in C#?

   Use `Array.Sort` function.

   ```C#
   int[] data = { 9, 5, 3, 9, 10};
   Array.Sort(data);
   foreach (var t in data)
   {
       Console.WriteLine(t);
   }
   ```
4. What property of an array object can be used to get the total number of elements in an array?

   instance`.Length`;
5. Can you store multiple data types in System.Array?

   Yes, we can declare an array of type `System.Object`. `System.Object` is the base type of all other types in C#.
6. What’s the difference between the `System.Array.CopyTo()` and `System.Array.Clone()`?

   Both the `System.Array.CopyTo()` method and the `System.Array.Clone()` method are used to create a copy of an array, but they have some differences in behavior:

   - For `CopyTo()`, it copies elements of one array to another existing array. It take 2 arguments: destination array and the starting index in the dest array will the copied elements will be placed.
   - For `Clone()`, it return a new copy of the original array objects. This is called Shallow copy.

### Practice Arrays

1. Copying an Array

   Write code to create a copy of an array. First, start by creating an initial array. (You can use whatever type of data you want.) Let’s start with 10 items. Declare an array variable and assign it a new array with 10 items in it. Use the things we’ve discussed to put some values in the array.

   Now create a second array variable. Give it a new array with the same length as the first. Instead of using a number for this length, use the Lengthproperty to get the size of the original array.

   Use a loop to read values from the original array and place them in the new array. Also print out the contents of both arrays, to be sure everything copied correctly.

   ```C#
   int[] myArray = new int[10];
   for (int i = 0; i < myArray.Length; i++)
   {
       myArray[i] = i * i;
   }
   Console.WriteLine($"myArray is {{{String.Join(", ", myArray)}}}");
   
   int[] copiedArray = new int[myArray.Length];
   for (int i = 0; i < myArray.Length; i++)
   {
       copiedArray[i] = myArray[i];
   }
   Console.WriteLine($"copiedArray is {{{String.Join(", ", copiedArray)}}}");
   
   ```

2. Write a simple program that lets the user manage a list of elements. It can be a grocery list, "to do" list, etc. Refer to Looping Based on a Logical Expression if necessary to see how to implement an infinite loop. Each time through the loop, ask the user to perform an operation, and then show the current contents of their list. The operations available should be Add, Remove, and Clear. The syntax should be as follows:

   ```
   + some item
   - some item
   --
   ```

   Your program should read in the user's input and determine if it begins with a `+` or `-` or if it is simply `--` . In the first two cases, your program should add or remove the string given ("some item" in the example). If the user enters just “—“ then the program should clear the current list. Your program can start each iteration through its loop with the following instruction:
   
   ```C#
   Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
   ```
   
   
