// Method that return the string
using System;
namespace StringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // This reverse a word
            string sentence = "there are snakes at the zoo";
            Console.WriteLine($"Reverse sentence is: {ReverseString(sentence)}");
            Console.WriteLine($"Each word are reversed: {ReverseEachWord(sentence)}");

            string ReverseEachWord(string sentence)
            {
                string resultOfSentence = "";
                string[] words = sentence.Split(" ");
                foreach (string word in words)
                {
                    resultOfSentence += ReverseString(word) + " ";
                }
                return resultOfSentence.Trim();
            }
            string ReverseString(string word)
            {
                string result = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    result += word[i];
                }
                return result;
            }

        }
    }
}