// See https://aka.ms/new-console-template for more information

using ColorSolution;

var ball1 = new Ball(5);
Console.WriteLine($"Try to throw Ball 1 now");
ball1.Throw();
Console.WriteLine($"Ball1 now threw {ball1.ThrowCount} times");
Console.WriteLine($"Try to throw Ball 1 now");
ball1.Throw();
Console.WriteLine($"Ball1 now threw {ball1.ThrowCount} times");
ball1.Pop();
Console.WriteLine($"Now pop Ball 1");
Console.WriteLine($"Try to throw Ball 1 now");
ball1.Throw();
Console.WriteLine($"Ball1 now threw {ball1.ThrowCount} times");