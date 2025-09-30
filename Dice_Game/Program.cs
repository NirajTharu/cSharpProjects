// If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
// If all three dice you roll result in the same value, you get six bonus points for rolling triples.
// If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game. Otherwise, you lose.


using System;
Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if (roll1 == roll2 && roll2 == roll3)
{
    Console.WriteLine("You rolled triples! + 6 bonus to total!");
    total += 6;
    Console.WriteLine($"Your total is {total}");
}
else if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! + 2 bonus to total!");
    total += 2;
    Console.WriteLine($"Your total is {total}");
}

if (total >= 15)
{
    Console.WriteLine("You have won the Game");
}
if (total < 15)
{
    Console.WriteLine("You Lose");
}
