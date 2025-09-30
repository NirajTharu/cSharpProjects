// Implement a method of the Math class that returns the larger of two numbers

using System;
namespace LargestOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = 500;
            int secondValue = 600;
            int largestValue;

            largestValue = Math.Max(firstValue, secondValue);
            Console.WriteLine(largestValue);
        }
    }
}