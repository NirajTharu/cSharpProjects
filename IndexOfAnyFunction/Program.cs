// The program file of the function IndexOfAny()
using System;
namespace IndexOfAny
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World!";
            char[] charsToFind = { 'a', 'l', 'W' };
            int index = message.IndexOfAny(charsToFind);

            while (index != -1)
            {
                Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");
                index = message.IndexOfAny(charsToFind, index + 1);
            }

            string message1 = "(What if) I have [different symbols] but every {open symbol} need a [matching closing symbol]? ";
            char[] openingSymbols = { '(', '[', '{' };
            int closingPosition = 0;
            while (true)
            {
                int openingPostion = message1.IndexOfAny(openingSymbols, closingPosition);
                if (openingPostion == -1) break;
                string currentSymbol = message1.Substring(openingPostion, 1);
                char matchingSymbol = ' ';
                switch (currentSymbol)
                {
                    case "[":
                        matchingSymbol = ']';
                        break;
                    case "{":
                        matchingSymbol = '}';
                        break;
                    case "(":
                        matchingSymbol = ')';
                        break;

                }
                openingPostion += 1;
                closingPosition = message1.IndexOf(matchingSymbol, openingPostion);
                int length = closingPosition - openingPostion;
                Console.WriteLine(message1.Substring(openingPostion, length));
            }

        }
    }
}