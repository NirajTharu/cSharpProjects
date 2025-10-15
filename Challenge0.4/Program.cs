// Exercise - Complete a challenge to combine string array values as strings and as integers

// Rule 1: If the value is alphabetical, concatenate it to form a message.

// Rule 2: If the value is numeric, add it to the total.


using System;
namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = { "12.3", "45", "ABC", "11", "DEF" };
            string alphabet = "";
            double total = 0;
            foreach (string value in values)
            {
                double number;
                if (double.TryParse(value, out number))
                {
                    total += number;
                }
                else
                {
                    alphabet += value;
                }
            }
            Console.WriteLine($"The total of the given string Adding only numbers: {total}");
            Console.WriteLine($"The string concatination is {alphabet}");
        }
    }
}