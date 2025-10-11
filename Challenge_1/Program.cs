/*In this challenge, we boil down that interaction to its essence.
A hero and a monster start with the same health score.
During the hero's turn, they generate a random value that is subtracted from the monster's health. 
If the monster's health is greater than zero, they take their turn and attack the hero.
As long as both the hero and the monster have health greater than zero, the battle resumes.*/


/*
Here are the rules for the battle game that you need to implement in your code project:

You must use either the do-while statement or the while statement as an outer game loop.
The hero and the monster start with 10 health points.
All attacks are a value between 1 and 10.
The hero attacks first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner
*/
using System;
namespace CodingChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            int monsterHealth = 10;
            int heroHealth = 10;
            Random random = new Random();
            do
            {
                int heroAttack = random.Next(1, 11);


                monsterHealth = monsterHealth - heroAttack;

                Console.WriteLine($"Monster Lost {heroAttack} Helth and reamaining helth of the monster is : {monsterHealth}.");

                if (monsterHealth > 0)
                {
                    int monsterAttack = random.Next(1, 11);
                    heroHealth = heroHealth - monsterAttack;
                    Console.WriteLine($"The hero lost {monsterAttack} health and the remaining helth is {heroHealth} ");
                }
            } while (heroHealth > 0 && monsterHealth > 0);
            Console.WriteLine(heroHealth > 0 ? "Hero Wins " : "Monster Wins");
        }
    }
}


