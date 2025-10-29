// Dice mini-game challenge
/*Your challenge is to design a mini-game.
The game should select a target number that is a random number between one and five (inclusive).
The player must roll a six-sided dice. To win, the player must roll a number greater than the target number.
At the end of each round, the player should be asked if they would like to play again, and the game should continue or terminate accordingly.*/


/*In the code that you start with, there are two unavailable methods referenced:

ShouldPlay: This method should retrieve user input and determine if the user wants to play again
WinOrLose: This method should determine if the player has won or lost
There are also two uninitialized variables:

target: The random target number between 1 and 5
roll: The result of a random six-sided die roll
Your challenge is to create the ShouldPlay and WinOrLose methods, and create methods that set target and roll to random values in the correct range. When all the methods are complete, the game should run successfully.

*/
using System;
namespace DiceMiniGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Would you like to play? (Y/N)");
            if (ShouldPlay())
            {
                PlayGame();
            }
            bool ShouldPlay()
            {
                string response = Console.ReadLine() ?? "";
                return response?.Trim().ToLower() == "y";
            }

            void PlayGame()
            {
                var play = true;

                while (play)
                {
                    var target = GetTarget();
                    var roll = RollDice();

                    Console.WriteLine($"Roll a number greater than {target} to win!");
                    Console.WriteLine($"You rolled a {roll}");
                    Console.WriteLine(WinOrLose(roll, target));
                    Console.WriteLine("\nPlay again? (Y/N)");

                    play = ShouldPlay();
                }
            }
            int GetTarget()
            {
                return random.Next(1, 6);
            }
            int RollDice()
            {
                return random.Next(1, 7);
            }
            string WinOrLose(int roll, int target)
            {
                if (roll > target)
                {
                    return "You win";
                }
                return "You Lose!";
            }
        }
    }
}