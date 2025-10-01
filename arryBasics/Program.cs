// Basics of array

/*Your work in the security department is focused on finding a pattern for fraudulent orders. 
You want your code to review past customer orders and identify markers associated with fraudulent orders. 
Your company hopes the markers can be used to identify potential fraudulent purchase orders in the future before they're processed. 
Since you don't always know in advance how many orders you need to review, you can't create individual variables to hold each Order ID. 
How can you create a data structure to hold multiple related values?*/

using System;
namespace ArrayBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] fraudlentOrdersIDs = new string[3];
            /*fraudlentOrdersIDs[0] = "A123";
            // fraudlentOrdersIDs[1] = "B456";
            // fraudlentOrdersIDs[2] = "C789";
            // fraudlentOrdersIDs[3] = "D000";
            */
            string[] fraudlentOrdersIDs = ["A123", "B456", "C789"];

            Console.WriteLine($"First: {fraudlentOrdersIDs[0]}");
            Console.WriteLine($"Second: {fraudlentOrdersIDs[1]}");
            Console.WriteLine($"Third: {fraudlentOrdersIDs[2]}");

            // Reassigning the value
            fraudlentOrdersIDs[0] = "F000";
            Console.WriteLine($"Reassigning value:{fraudlentOrdersIDs[0]}");
            Console.WriteLine($"There are {fraudlentOrdersIDs.Length} fraudulent order to process.");
        }
    }
}