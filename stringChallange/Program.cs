/*Earlier in this module, you set out to write code that would store Order IDs belonging to potentially fraudulent orders. Your goal is to find fraudulent orders as early as possible and flag them for deeper analysis.
*/

using System;
namespace StringChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fraudlentOrdersID = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
            foreach (string fraud in fraudlentOrdersID)
            {
                if (fraud.StartsWith("B"))
                {
                    Console.WriteLine($"The name starts with B:{fraud}");
                }
            }
        }
    }
}