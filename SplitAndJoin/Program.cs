// Split and join operations
using System;
using System.Diagnostics;
namespace SplitAndJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Console.WriteLine(valueArray);
            Array.Reverse(valueArray);
            string result = new string(valueArray);
            Console.WriteLine(result);

            // Dividing the string by characters with a comma(,)
            string book = "BookCoverIsLookingGood";
            char[] wordsOfBook = book.ToCharArray();
            Array.Reverse(wordsOfBook);

            // first Final part
            string bookResult = String.Join(",", wordsOfBook);
            Console.WriteLine(bookResult);

            // second Final part
            // if Wanted the to display the string with out comma
            string[] items = bookResult.Split(",");
            foreach (string item in items)
            {
                Console.Write(item);
            }
        }
    }
}