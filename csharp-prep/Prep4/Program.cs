using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("");

        List<int> numbers = new List<int>();

        int guessNumber = -1;
        while (guessNumber != 0)
        {
            Console.Write("Enter a number (enter 0 to quit): ");
            string guess = Console.ReadLine();
            guessNumber = int.Parse(guess);

             if (guessNumber != 0) 
             {
                numbers.Add(guessNumber);
             }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The Sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest is: {largest}");


        int smalest = numbers[0];
        foreach ( int number in numbers)
        {
            if (number < smalest)
            {
                smalest = number;
            }
        }
        Console.WriteLine($"The smalest is: {smalest}");
    
    }
}