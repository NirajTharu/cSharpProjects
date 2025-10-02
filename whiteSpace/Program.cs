// About the white space and its use 

using System;
namespace WhiteSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.
            // WriteLine
            // (
            //     "Hi there"
            // );

            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;
            Console.WriteLine($"The total is: {roll1} + {roll2} + {roll3} = {total}");

            if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
            {
                if (roll1 == roll2 && roll2 == roll3)
                {
                    Console.WriteLine("Your rolled triples ! + 6 bonus");
                    total += 6;
                }
                else
                {
                    Console.Write("You rolled bouble ! + 2 bonus!");
                    total += 2;
                }
            }
        }
    }
}