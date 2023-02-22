using System.Text;
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

// FuzzBuzz();

void GuessNumber()
{
    int correctNumber = new Random().Next(3) + 1;
    int guess;
    do
    {
        try
        {
            guess = int.Parse(Console.ReadLine()??"0");
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

// GuessNumber();

void PrintPyramid(int height)
{
    int width = height * 2 - 1;
    var sb = new StringBuilder();
    sb.Append(' ', width);
    for (int i = 0; i < height; ++i)
    {
        sb[width / 2 + i] = '*';
        sb[width / 2 - i] = '*';
        Console.WriteLine(sb);
    }
}

// int height = Int32.Parse(Console.ReadLine()??"1");
// PrintPyramid(height);

void GetAge()
{
    Console.WriteLine("Enter your birth date:");
    int birthYear = Int32.Parse(Console.ReadLine()??"0");
    int birthMonth = Int32.Parse(Console.ReadLine()??"0");
    int birthDay = Int32.Parse(Console.ReadLine()??"0");
    if (birthMonth > 12 || birthMonth < 1)
    {
        Console.WriteLine("Invalid month");
        return;
    }
    if (birthDay > 31 || birthDay < 1)
    {
        Console.WriteLine("Invalid day");
        return;
    }

    int age = DateTime.Now.Year - birthYear - 1;
    if (DateTime.Now.Month > birthMonth)
        age++;
    else if (DateTime.Now.Month == birthMonth && DateTime.Now.Day >= birthDay)
        age++;
    Console.WriteLine($"Your age is { age }");
    var birthDate = new DateTime(birthYear, birthMonth, birthDay);
    // Print 10000 days after your birth
    var newDate = birthDate.AddDays(10000);
    Console.WriteLine(@$"Next 27 years anniversary (10000 days) is:
{newDate.Day}/{newDate.Month}/{newDate.Year}");
}

// GetAge();

void TimeGreeting()
{
    DateTime now = DateTime.Now;
    if (now.Hour is >= 6 and < 12)
        Console.WriteLine("Good morning");
    else if (now.Hour is >= 12 and < 18)
        Console.WriteLine("Good afternoon");
    else if (now.Hour is >= 18 and < 22)
        Console.WriteLine("Good evening");
    else
        Console.WriteLine("Good night");
}

// TimeGreeting();

void IncrementByNestedFor()
{
    for (int incr = 1; incr <= 4; ++incr)
    {
        Console.Write('0');
        for (int i = incr; i <= 24; i+=incr)
        {
            Console.Write(',');
            Console.Write(i);
        }
        Console.Write('\n');
    }
}

// IncrementByNestedFor();
