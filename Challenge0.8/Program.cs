// Exercise - Complete a challenge to apply string interpolation to a form letter

/*. Your job is to write C# code to merge personalized information about the customer.
The letter contains information like their existing portfolio and compares their current
returns to projected returns if they were to invest in using the new products.*/
using System;
namespace LetterFormation
{
    class Program
    {
        static void Main(string[] args)
        {
            string customerName = "Ms. Barros";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            string second = "As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.";
            string firstResult = string.Format("Dear {0},\n{1}", customerName, second);
            Console.WriteLine(firstResult);
            Console.WriteLine("");
            Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.");
            Console.WriteLine("");
            string third = "Our third product, ";
            string fourth = $"Glorious Future offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:N2}";
            string secondResult = string.Format("{0} {1}", third, fourth);
            Console.WriteLine(secondResult);
            Console.WriteLine("");
            Console.WriteLine("Here's a quick comparison:\n");
            // Console.WriteLine("");
            string comparisonMessage = "";
            comparisonMessage = currentProduct.PadLeft(11);
            comparisonMessage += String.Format("{0:P2}", currentReturn).PadLeft(22);
            comparisonMessage += String.Format("{0:C2}", currentProfit).PadLeft(33);
            comparisonMessage += "\n";

            comparisonMessage += newProduct.PadLeft(11);
            comparisonMessage += String.Format("{0:P2}", newReturn).PadLeft(18);
            comparisonMessage += String.Format("{0:C2}", newProfit).PadLeft(33);
            Console.WriteLine(comparisonMessage);
        }
    }
}