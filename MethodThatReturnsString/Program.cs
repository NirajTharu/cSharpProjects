// Method that return the string
using System;
namespace StringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // This reverse a word
            string input = "snake";
            ReverseWord(input);
            Console.WriteLine($"Reverse word is: {ReverseWord(input)}");
            string ReverseWord(string word)
            {
                string result = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    result += word[i];
                }
                return result;
            }
            string sentence = "";
        }
    }
}