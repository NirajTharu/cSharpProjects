// Find the substring in the given string
using System;
namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Find what is (inside the parentheses)";
            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');
            Console.WriteLine(openingPosition);
            Console.WriteLine(closingPosition);
            openingPosition += 1;
            int Length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, Length));

            string message1 = "What is the value <span>between the tags</span>";
            const string openspan = "<span>";
            const string closespan = "</span>";
            int openingPosition1 = message1.IndexOf(openspan);
            int closingPosition1 = message1.IndexOf(closespan);
            openingPosition1 += 6;
            int length = closingPosition1 - openingPosition1;
            Console.WriteLine(message1.Substring(openingPosition1, length));
        }
    }
}