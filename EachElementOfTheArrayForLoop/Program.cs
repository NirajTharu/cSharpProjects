// Loop through the each element of the array
using System;
namespace LoopThroughEachElementOfTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Alex", "Eddie", "David", "Michael" };
            // BackWard iteration
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(name[i]);
            }
            // Forward iteration
            Console.WriteLine("For the forward iteration:");
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}