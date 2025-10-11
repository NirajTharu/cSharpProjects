// To check the value is numeric or not
using System;
namespace NumberiValue
{
    class Program
    {
        static void Main(string[] args)
        {
            string? inputString;
            int numericValue = 0;
            bool validNumber = false;

            Console.WriteLine("Enter the Numeric Value:");
            inputString = Console.ReadLine();

            validNumber = int.TryParse(inputString, out numericValue);
            Console.WriteLine($"The value is numeric: {validNumber}");

        }
    }
}