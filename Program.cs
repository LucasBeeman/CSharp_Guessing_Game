using System;
using System.Collections.Generic;

namespace RandomNumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> guessList = new List<int>();
            int size = 2147483646;
            int answer = rand.Next(size + 1);
            int guess = size / 2;
            int min = 0;
            int max = size;
            int miss = 0;
            int guessNum = 0;
            Console.WriteLine("The answer is " + answer);

            while (guess != answer)
            {
                if (guess > answer)
                {
                    max -= max - guess - 1;
                    miss++;
                }
                else if (guess < answer)
                {
                    min = guess + 1;
                    miss++;
                }
                guess = rand.Next(min, max);
                guessList.Add(guess);
                guessNum++;
                Console.WriteLine(guessList[guessNum - 1]);
            }
            Console.WriteLine("\nThe correct number is " + answer);
            Console.WriteLine("\nThe bot has missed " + miss + " times");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}