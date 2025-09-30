// Overloaded Methods

using System;
namespace OverloadedMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int roll1 = dice.Next();
            int roll2 = dice.Next(101);
            int roll3 = dice.Next(50, 101);

            Console.WriteLine($"Frist Roll:{roll1}");
            Console.WriteLine($"Second Roll:{roll2}");
            Console.WriteLine($"Third Roll:{roll3}");
            
        }
    }
}