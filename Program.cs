using System;


int RandomNumber()
{
    int dieValue = new Random().Next(1, 50);
    return dieValue;
}

int secretNumber = RandomNumber();

Console.WriteLine("Guess and try to figure out my secret number in 4 attempts: ");

var input = int.Parse(Console.ReadLine());

if (input == secretNumber)
{
    Console.WriteLine("You hacker.");
}
else
{
    for (int i = 2; i < 5; i++)
    {
        if (input < secretNumber)
        {
            Console.WriteLine("Too Low!");
        }
        else
        {
            Console.WriteLine("Too High!");
        }
        Console.Write($"(Attempt {i}) Try again: ");
        input = int.Parse(Console.ReadLine());
        if (input == secretNumber)
        {
            Console.WriteLine("Good job! You guessed it.");
            break;
        }
    }
    Console.WriteLine($"The number was {secretNumber}");
}




