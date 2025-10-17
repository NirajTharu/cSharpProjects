// Challenge
using System;
namespace ReverseWordsInSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string pangrams = "The quick brown fox jump over the lazy dog";
            string[] SplitedStrings = pangrams.Split(' ');
            for (int i = 0; i < SplitedStrings.Length; i++)
            {
                char[] valuePangrams = SplitedStrings[i].ToCharArray();
                Array.Reverse(valuePangrams);
                SplitedStrings[i] = new string(valuePangrams);
            }
            string JoinedStrings = String.Join(" ", SplitedStrings);
            Console.WriteLine(JoinedStrings);
        }
    }
}