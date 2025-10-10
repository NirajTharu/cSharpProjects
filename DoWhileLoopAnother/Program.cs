
//  Do while loop
using System;
namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int current = random.Next(1, 11);
            do
            {
                current = random.Next(1, 11);
                if (current >= 8)
                    continue;
                Console.WriteLine(current);
            } while (current != 7);
        }
    }
}