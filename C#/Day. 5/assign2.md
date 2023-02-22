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
   void CopyArray() {
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
   }
   ```

2. Write a simple program that lets the user manage a list of elements. It can be a grocery list, "to do" list, etc. Refer to Looping Based on a Logical Expression if necessary to see how to implement an infinite loop. Each time through the loop, ask the user to perform an operation, and then show the current contents of their list. The operations available should be Add, Remove, and Clear. The syntax should be as follows:

   ```
   + some item
   - some item
   --
   ```

   Your program should read in the user's input and determine if it begins with a `+` or `-` or if it is simply `--` . In the first two cases, your program should add or remove the string given ("some item" in the example). If the user enters just “—“ then the program should clear the current list. Your program can start each iteration through its loop with the following instruction:

   ```C#
   void ListManager()
   {
       Console.WriteLine("Enter command (+ item, - item, list, or -- to clear)):");
       var items = new HashSet<string>();
       while (true)
       {
           string? command = Console.ReadLine();
           if (string.IsNullOrEmpty(command))
           {
               continue;
           }
           if (command.StartsWith("+ "))
           {
               items.Add(command[2..]);
           }
           else if (command.StartsWith("- "))
           {
               items.Remove(command[2..]);
           }
           else if (command == "--")
               items.Clear();
           else if (command.ToLower() == "list")
               ;
           else
           {
               Console.WriteLine("Invalid commands, enter command (+ item, - item, or -- to clear)).");
               continue;
           }
           Console.WriteLine(string.Join(", ", items));
       }
   }
   ```

3. Write a method that calculates all prime numbers in given range and returns them as array of integers

   ```C#
   static bool IsPrime(int num)
   {
       if (num < 2) {
           return false;
       }
       for (int i = 2; i <= Math.Sqrt(num); i++) {
           if (num % i == 0) {
               return false;
           }
       }
       return true;
   }
   
   static int[] FindPrimesInRange(int startNum, int endNum)
   {
       List<int> primes = new List<int>();
       for (int i = startNum; i <= endNum; i++) {
           if (IsPrime(i)) {
               primes.Add(i);
           }
       }
       return primes.ToArray();
   }
   ```

4. Write a program to read an array of n integers (space separated on a single line) and an integer k, rotate the array right k times and sum the obtained arrays after each rotation as shown below.

   - After r rotations the element at position I goes to position (I + r) % n.

   - The sum[] array can be calculated by two nested loops: `for r = 1 ... k`; for `I = 0 ... n-1`

   ```C#
   int [] rotateArrayAndSum(int []array, int k)
   {
       int [] sum = new int [array.Length];
       while (k > 0)
       {
           int last = array[array.Length - 1];
           for (int i = array.Length - 1; i > 0; --i)
           {
               array[i] = array[i - 1];
           }
           array[0] = last;
           
           for (int i = 0; i < array.Length; ++i)
           {
               sum[i] += array[i];
           }
           
           --k;
       }
       return sum;
   }
   ```

5. Write a program that finds the longest sequence of equal elements in an array of integers. If several longest sequences exist, print the leftmost one.

   ```C#
   void FindLongestSequence(int []arr)
   {
       var stat = new Dictionary<int, int>();
       var maxCount = 0;
       var maxElement = 0;
       foreach (var ele in arr)
       {
           if (!stat.ContainsKey(ele))
               stat[ele] = 0;
           stat[ele]++;
           if (stat[ele] > maxCount)
           {
               maxCount = stat[ele];
               maxElement = ele;
           }
       }
       for (int i = 0; i < maxCount; i++)
           Console.Write(maxElement + " ");
       Console.Write('\n');
   }
   
   FindLongestSequence(new [] {2, 1, 1, 2, 3, 3, 2, 2, 2, 1});
   FindLongestSequence(new [] {1, 1, 1, 2, 3, 1, 3, 3});
   FindLongestSequence(new [] {4, 4, 4, 4});
   FindLongestSequence(new [] {0, 1, 1, 5, 2, 2, 6, 3, 3});
   ```

6. Write a program that finds the most frequent number in a given sequence of numbers. In case of multiple numbers with the same maximal frequency, print the leftmost of them

   ```C#
   using System.Text;
   
   void MostFrequentNumber(int []arr)
   {
       var stat = new Dictionary<int, int>();
       var maxCount = 0;
       var maxElement = 0;
       foreach (var ele in arr)
       {
           if (!stat.ContainsKey(ele))
               stat[ele] = 0;
           stat[ele]++;
           if (stat[ele] > maxCount)
           {
               maxCount = stat[ele];
               maxElement = ele;
           }
       }
   
       var result = new List<int>();
       foreach (var item in stat)
       {
           if (item.Value == maxCount)
               result.Add(item.Key);
       }
       if (result.Count == 1)
           Console.WriteLine($"The number {maxElement} is the most frequent (occurs {maxCount} times).");
       else
       {
           result.Sort();
           var sb = new StringBuilder();
           sb.Append(result[0]);
           for (int i = 1; i < result.Count - 1; i++)
           {
               sb.Append(", ");
               sb.Append(result[i]);
           }
           sb.Append(" and ");
           sb.Append(result[result.Count - 1]);
           
           Console.WriteLine($"The numbers {sb} are the most frequent (each occurs {maxCount} times). The leftmost of them is {maxElement}.");
       }
   }
   
   MostFrequentNumber(new [] {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3});
   MostFrequentNumber(new [] {7, 7, 7, 0, 2, 2, 2, 0, 10, 10, 10});
   ```

### Practice Strings

1. ```C#
   void ReverseString(string str)
   {
       char[] charArray = str.ToCharArray();
       Array.Reverse(charArray);
       Console.WriteLine(charArray);
   }
   
   ReverseString("sample");
   ```
   
   ```C#
   void ReverseString(string str)
   {
       for (int i = str.Length - 1; i >= 0; --i)
           Console.Write(str[i]);
       Console.Write('\n');
   }
   
   ReverseString("24tvcoi92");
   ```
   
2. ```C#
   void Problem2(string sentence) {
       var wordsAndSeparators = sentence.Split(new char[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);
   
       wordsAndSeparators = wordsAndSeparators.Where(w => !string.IsNullOrWhiteSpace(w)).ToArray();
       Array.Reverse(wordsAndSeparators);
       
       var separators = sentence.Split(wordsAndSeparators, StringSplitOptions.RemoveEmptyEntries);
       int i = 0;
       sentence = string.Join("", wordsAndSeparators.Select(w =>
       {
           if (i < separators.Length)
               return !(string.IsNullOrWhiteSpace(w)) ? $"{w}{separators[i++]}" : separators[i++];
           return w;
       }));
   
       Console.WriteLine(sentence); // Prints "sentence sample a is This, marks punctuation some with!"
   }
   
   Problem2("This is a sample sentence, with some punctuation marks!");
   Problem2("The quick brown fox jumps over the lazy dog /Yes! Really!!!/.");
   ```
   
3. ```C#
   void FindPalindromes(string s)
   {
       var words = s.Split(new[] { ' ', ',', '.', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?'},
           StringSplitOptions.RemoveEmptyEntries);
       var palindromes = words.Where(w => w == new string(w.Reverse().ToArray()));
       var set = new SortedSet<string>();
       foreach (var palindrome in palindromes)
       {
           set.Add(palindrome);
       }
       Console.WriteLine(String.Join(", ", set));
   }
   
   FindPalindromes("Hi,exe? ABBA! Hog fully a string: ExE. Bob");
   ```
   
4. ```C#
   using System.Text.RegularExpressions;
   
   void URLPattern(string s)
   {
       // fetch protocol, server and resource
       string pattern = @"(https?://)([^/]+)(.*)";
       var match = Regex.Match(s, pattern);
       var protocol = match.Groups[1].Value;
       var server = match.Groups[2].Value;
       var resource = match.Groups[3].Value;
       Console.WriteLine($"protocol: {protocol}");
       Console.WriteLine($"server: {server}");
       Console.WriteLine($"resource: {resource}");
   }
   
   URLPattern("https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/");
   URLPattern("http://www.google.com");
   ```
