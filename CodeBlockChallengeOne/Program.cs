/*1. A developer writes some code that includes an if statement code block. 
They initialize one integer variable to a value of 5 above (outside) of the code block. 
They initialize a second integer variable to a value of 6 on the first line inside of the code block. 
The Boolean expression for the code block evaluates to true if the first integer variable has a value greater than 0. 
On the second line inside the code block, they assign the sum of the two values to the first variable. 
On the first line after the code block, they write code to display the value of the first integer. 
What is the result when the code statement used to display the first integer is executed?

// Correct Answer : No error is generated and the integer value is displayed. The value displayed is the sum of the first and second integer.

No error is generated and the integer value is displayed. The value displayed is the initialized value from above the code block.

An error is generated because the first variable isn't in-scope after the code block.
*/

using System;
namespace CodeBlokeChallengeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInteger = 5;
            if (firstInteger > 0)
            {
                int secondInteger = 6;
                firstInteger = firstInteger + secondInteger;
            }
            Console.WriteLine($"{firstInteger}");
        }
    }
}