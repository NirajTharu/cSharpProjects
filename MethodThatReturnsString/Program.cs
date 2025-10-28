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
            Console.WriteLine($"Reverse word is: {ReverseWord(sentence)}");
            Console.WriteLine($"The reverse sentnece is:{ReverseSentence(sentence)}");

            string ReverseSentence(string sentence)
            {
                string resultOfSentence = "";
                string[] words = sentence.Split(" ");
                foreach (string word in words)
                {
                    resultOfSentence += ReverseWord(word) + " ";
                }
                return resultOfSentence.Trim();
            }
            string ReverseWord(string word)
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