// Using the indexOf and LastIndexOf() helper method
using System;
namespace LastIndexOfMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "hello there!";
            int first_h = message.IndexOf('h');
            int last_h = message.LastIndexOf('h');
            Console.WriteLine($"For the Given message '{message}', the first 'h' is at position {first_h} and the last 'h' is at the postion of {last_h}.");

            // Retreving the last occurance of a substring
            string message1 = "(What if) I am (only interested) in the last (set of parentheses)?";
            // int openingPostion = message1.LastIndexOf('(');
            // openingPostion += 1;
            // int closingPosition = message1.LastIndexOf(')');
            // int length = closingPosition - openingPostion;
            // Console.WriteLine(message1.Substring(openingPostion, length));

            // Retreving all the substrings inside the parenthesis
            while (true)
            {
                int openingPostion = message1.IndexOf('(');
                if (openingPostion == -1) break;
                openingPostion += 1;
                int closingPosition = message1.IndexOf(')');
                int length = closingPosition - openingPostion;
                Console.WriteLine(message1.Substring(openingPostion, length));
                message1 = message1.Substring(closingPosition + 1);
            }

        }
    }
}