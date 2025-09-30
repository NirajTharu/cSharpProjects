// To get the random dice number from using the random functionn in c#
using System;
namespace Dice_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int roll = dice.Next(1, 7);
            Console.WriteLine(roll);
        }
    }
}