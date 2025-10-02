// Code readablity challenge 
using System;
namespace CodeReadability
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = " The quick brown fox jump over the lazy dog.";

            // convert the meassage into a char array
            char[] charMessage = str.ToCharArray();

            // Reverse the chars
            Array.Reverse(charMessage);

            int x = 0;
            // count the o's
            foreach (char i in charMessage) { if (i == 'o') { x++; } }

            // Convert it back to the string
            string new_message = new string(charMessage);

            // print it out
            Console.WriteLine(new_message);
            Console.WriteLine($"The 'o' appears {x} times in the meassage.");
        }
    }
}