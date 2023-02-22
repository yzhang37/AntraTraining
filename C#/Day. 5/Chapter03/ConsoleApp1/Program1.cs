// FizzBuzz

void FuzzBuzz() {
    for (int i = 1; i <= 100; ++i)
    {
        if (i % 15 == 0)
            Console.WriteLine("FizzBuzz");
        else if (i % 5 == 0)
            Console.WriteLine("Buzz");
        else if (i % 3 == 0)
            Console.WriteLine("Fizz");
        else
            Console.WriteLine(i);
    }
}

FuzzBuzz();

void GuessNumber()
{
    int correctNumber = new Random().Next(3) + 1;
    int guess = 0;
    do
    {
        try
        {
            guess = int.Parse(Console.ReadLine());
            if (guess < 1 || guess > 3)
                Console.WriteLine("Guess should within 1 to 3");
            else if (guess < correctNumber)
                Console.WriteLine("The correct is greater than your guess");
            else if (guess > correctNumber)
                Console.WriteLine("The correct is less than your guess");
            else
            {
                Console.WriteLine("You guessed it!");
                break;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Bad input");
        }
    } while (true);
}

GuessNumber();
