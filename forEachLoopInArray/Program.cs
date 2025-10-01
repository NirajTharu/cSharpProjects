// foreach Loop in the array
using System;
namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This array is of the String Datatype.");
            string[] names = ["Rowena", "Robin", "Bao"];
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            int sum = 0;
            int bin = 0;
            Console.WriteLine("This array is of the intiger datatype:");
            int[] inventery = { 200, 450, 700, 175, 250 };
            foreach (int items in inventery)
            {
                // Console.Write(items);
                sum += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} item (Runnint Total: {sum})");
            }
            Console.WriteLine($"The sum of the items is: {sum}");
        }
    }
}