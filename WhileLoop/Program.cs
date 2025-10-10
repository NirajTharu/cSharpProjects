// While loop

using System;
namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Random current = new Random();
            int value = current.Next(1, 56);
            while (value >= 7)
            {
                Console.WriteLine(value);
                value = current.Next(1, 56);
            }
            Console.WriteLine($"The value of the value is:{value}");
        }
    }
}