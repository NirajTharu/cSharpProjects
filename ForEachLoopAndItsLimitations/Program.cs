// For each loop and its limitations
using System;
namespace ForEachloopAndItsLimitations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Alex", "Eddie", "David", "Michael" };
            // foreach (var name in names)
            // {
            //     // LimitationOfForEachLoop
            //     // if (name = "Alex") name = "Sammy";
            //     Console.WriteLine(name);
            // }
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "Alex") names[i] = "Sammy";
            }
            foreach (var name in names)
                Console.WriteLine(name);

        }
    }
}