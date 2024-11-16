using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        // int magicNumber = 7;

        int guessNumber = -1;
        int guessCount = 0;
        
        while (magicNumber != guessNumber)
        {
            Console.Write("Guess the magic number: ");
            string number = Console.ReadLine();
            guessNumber = int.Parse(number);

            guessCount++;

            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Your guess is higher, Please guess lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Your guess is lower, Please guess higer.");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {guessCount} guesses.");
            }
        }
        
    }
}