/* Data comes in many formats. 
In this challenge you have to parse the individual 
"Order IDs", and output the "OrderIDs" sorted and tagged as "Error"
if they aren't exactly four characters in length.*/
using System;
namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given data
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] splittedStrings = orderStream.Split(",");
            Array.Sort(splittedStrings);
            foreach (string splittedString in splittedStrings)
                if (splittedString.Length == 4)
                    Console.WriteLine(splittedString);
                else
                    Console.WriteLine($"{splittedString}\t- Error");
        }
    }
}


