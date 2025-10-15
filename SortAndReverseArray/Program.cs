//  Reverse and sort an array
using System;
namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pallets = ["B14", "A11", "B12", "A13"];
            Console.WriteLine("--Sorted Array--");
            Array.Sort(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine(pallet);
            }

            // Reversing the array
            Console.WriteLine("--The Reverse Array--");
            Array.Reverse(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine(pallet);
            }
        }
    }
}
