/*
Here are the conditions that your first coding project must implement:

Your solution must include either a do-while or while iteration.

Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

Inside the iteration block:

Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the input is a valid representation of an integer.
If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

*/

using System;
namespace IntegerAcceptance
{
    class Program
    {
        static void Main(string[] args)
        {
            string? EnteredValue;
            int number = 0;

            bool value = false;
            Console.WriteLine("Enter the integer between 5 and 10:");
            do
            {
                EnteredValue = Console.ReadLine();
                value = int.TryParse(EnteredValue, out number);
                if (value == false)
                {
                    Console.WriteLine("Sorry you enterd invalid Number, please try again");
                }
                else if (value == true)
                {
                    if (number < 5 || number > 10)
                    {
                        Console.WriteLine($"You Entered {number}. Please Enter the number between 5 and 10");

                    }
                    else if (number >= 5 || number <= 10)
                    {
                        Console.WriteLine($"Your Input value({number}) is Accepted.");
                    }
                }
            } while (value == false || number < 5 || number > 5);
        }
    }
}