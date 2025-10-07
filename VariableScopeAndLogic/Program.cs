/*A developer writes some code that includes an if statement code block. 
They initialize a first integer variable to a value of 1 above (outside) of the code block. 
The Boolean expression for the if statement code block evaluates to true if the first integer variable has a value greater than 0. 
The first code line inside of the code block is used to initialize a second integer variable to a value of 8. 
The second code line inside the code block is used to assign the sum of the two integer values to the first variable. 
The first code line after the code block is used to display the value of the first integer variable.
What is the result when the code is executed?

No error is generated and the integer value 9 is displayed.

No error is generated and the integer value 1 is displayed.

An error is generated because the first variable is not in-scope after the code block.*/

using System;
namespace VariableScopeAndLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            firstInteger = 1;
            bool flag = false;
            if (firstInteger > 0)
            {
                secondInteger = 8;
                firstInteger = firstIngeger + secondIngeger;
                flag = true;
            }
            Console.WriteLine($"The value of first integer is:{firstInteger}");
        }
    }
}