// Use array methods to clear and resize an array

using System;
namespace ClearAndReverseMethods
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] pallets = ["B14", "A11", "B12", "A13"];

            Console.WriteLine($"Before:-- {pallets[0]}");
            Array.Clear(pallets, 0, 2);
            Console.WriteLine($"After:-- {pallets[0]}");


            Console.WriteLine($"Clearing 2 ... Count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            Array.Resize(ref pallets, 6);
            Console.WriteLine($"Resizing the array to {pallets.Length} ");

            pallets[4] = "C01";
            pallets[5] = "C02";

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"--{pallet}");
            }

            Array.Resize(ref pallets, 3);
            Console.WriteLine($"Resizing the array to 3:- {pallets.Length}");
        }
    }
}