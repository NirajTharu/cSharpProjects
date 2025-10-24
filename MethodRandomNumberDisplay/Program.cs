// Building the method to display the random number
using System;
using System.Diagnostics;
namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generating random Numbers:");
            DisplayRandomNumbers();
            void DisplayRandomNumbers()
            {
                Random random = new Random();
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{random.Next(1, 50)} ");
                }
                Console.WriteLine();
            }
        }
    }
}