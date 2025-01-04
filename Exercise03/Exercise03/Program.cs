namespace Exercise03;

class Program
{

    static void FizzBuzz()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            } else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
        }
    }
    static void GuessRandomNumber()
    {
        int correctNumber = new Random().Next(3) + 1; //range 1 to 3 
        
        //user guess: 
        Console.WriteLine("Guess a number between 1 and 3");
        int guess = int.Parse(Console.ReadLine());
        //check the range 
        while (guess < 1 || guess > 3)
        {
            Console.WriteLine("Invalid number, give a number between 1 and 3");
            guess = int.Parse(Console.ReadLine());
        }
        //check the guess 
        if (guess > correctNumber)
        {
            Console.WriteLine("Your guess was high "+correctNumber);
        } else if (guess < correctNumber)
        {
            Console.WriteLine("Your guess was low " + correctNumber);
        }
        else if (guess == correctNumber)
        {
            Console.WriteLine("Your guess was correct.");
        }
    }

    static void PrintPyramid(string method)
    {
        Console.WriteLine("Enter Pyramid Height:");
        int pyramidHeight = Convert.ToInt32(Console.ReadLine());
        if (method == "stringMutliplication")
        {

            for (int i = 1; i <= pyramidHeight; i++)
            {
                Console.WriteLine(new string(' ', pyramidHeight - i) + new string('*', 2 * i - 1));
            }
        } else if (method == "n2")
        {
            for (int row = 1; row <= pyramidHeight; row++) 
            {
                //printSpace: 
                for (int space = 1; space <= pyramidHeight -row ; space++)
                {
                    Console.Write(' ');
                }

                for (int star = 1; star <= 2* row - 1; star++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

    }

    static void DaysOld()
    {
        DateTime birthday = new DateTime(1995, 09, 07);
        DateTime today = DateTime.Today;
        int daysOld = (today - birthday).Days;
        int daysToNextAniversary = 10000 - (daysOld % 10000);
        DateTime nextAniversary = today.AddDays(daysToNextAniversary);
        Console.WriteLine($"You are {daysOld:n0} days old.");
        Console.WriteLine($"You next 10000 day is in:  {nextAniversary:d} or  days.");
    }

    static void GreetingTime()
    {
        DateTime today = DateTime.Now;
        int hour = today.Hour;
        string greeting = "";
        if (hour >= 4 && hour < 12)
        {
            greeting = "Good Morning";
        }

        if (hour >= 12 && hour < 17)
        {
            greeting = "Good Afternoon";
        }

        if (hour >= 17 && hour < 21)
        {
            greeting = "Good Evening";
        }

        if (hour >= 21 && hour < 4)
        {
            greeting = "Good Night";
        }
        Console.WriteLine(greeting);
        
        
    }

    static void LoopTwentyFour()
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 0; j <= 24; j += i)
            {
                Console.Write(j);
                if (j < 24)
                {
                    Console.Write(", ");

                }
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        // FizzBuzz();
        // GuessRandomNumber();
        // PrintPyramid("n2");
        // DaysOld();
        // GreetingTime();
        LoopTwentyFour();
    }
}