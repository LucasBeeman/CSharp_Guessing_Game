﻿using System;

namespace RandomNumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int size = 100;
            int answer = rand.Next(size + 1);
            int guess = size / 2;
            int min = 0;
            int max = size;
            int miss = 0;

            Console.WriteLine("The answer is " + answer);

            while (guess != answer)
            {
                if (guess > answer)
                {
                    max -= size - guess;
                    miss++;
                    if(max < min)
                    {
                        min = 0;
                    }
                }
                else if (guess < answer)
                {
                    min = guess +1;
                    miss++;
                }
                guess = rand.Next(min, max + 1);
                Console.WriteLine(guess);
                Console.WriteLine(max);
                Console.WriteLine(min);
                Console.WriteLine("-------------");

            }
            Console.WriteLine("\nThe correct number is " + answer);
            Console.WriteLine("\nThe bot has missed " + miss + " times");
        }
    }
}