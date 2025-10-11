// Using the do while loop for the user input
using System;
namespace NullAbleValue
{
    class Program
    {
        static void Main(string[] args)
        {
            string? inputString;
            bool validEntry = false;
            Console.WriteLine("Enter the string contaning at least 3 character:");
            do
            {
                inputString = Console.ReadLine();
                if (inputString != null)
                {
                    if (inputString.Length >= 3)
                    {
                        validEntry = true;
                    }
                    else
                    {
                        Console.WriteLine("Your input is invalid try again later.");
                    }
                }
            } while (validEntry == false);
        }
    }
}