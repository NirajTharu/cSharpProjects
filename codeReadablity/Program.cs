// Code readablity challenge 
using System;
namespace CodeReadability
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalMessage = " The quick brown fox jump over the lazy dog.";

            char[] message = originalMessage.ToCharArray();
            Array.Reverse(message);

            int letterCount = 0;
            foreach (char letter in message)
            {
                if (letter == 'o')
                {
                    letterCount++;
                }
            }
            string new_message = new string(message);

            Console.WriteLine(new_message);
            Console.WriteLine($"The 'o' appears {letterCount} times in the meassage.");
        }
    }
}