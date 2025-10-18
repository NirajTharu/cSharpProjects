// About the string formatting basics in C#
using System;
namespace StringFromatting
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Composite formatting uses numbered placeholders within a string. 
           At run time, everything inside the braces is resolved to a value that is also passed in based on their position.*/
            string first = "Hello";
            string second = "world";
            string result = string.Format("{0} {1}!", first, second);
            Console.WriteLine(result);
        }
    }
}