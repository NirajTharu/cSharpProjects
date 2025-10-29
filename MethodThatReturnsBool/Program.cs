// Method that returns bool
using System;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
namespace BoolMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Checking the palandrome
            string[] words = { "racecar", "talented", "deified", "tent", "tenet" };
            Console.WriteLine("It is palindrome?");
            foreach (string word in words)
            {
                Console.WriteLine($"{word} : {IsPalindrome(word)}");
            }

            bool IsPalindrome(string word)
            {
                int start = 0;
                int end = word.Length - 1;
                while (start < end)
                {
                    if (word[start] != word[end])
                    {
                        return false;
                    }
                    start++;
                    end--;
                }
                return true;
            }
        }
    }
}