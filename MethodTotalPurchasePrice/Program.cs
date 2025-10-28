// This program contains the Method which helps to calculate the total price of the certain purchase
using System;
namespace TotalPurchasePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0.00;
            double minimumSpend = 30.00;
            double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
            double[] discount = { 0.30, 0.00, 0.10, 0.20, 0.50 };

            for (int i = 0; i < items.Length; i++)
            {
                total += GetDiscountPrice(i);
            }
            if (TotalMeetsMinimum())
            {
                total -= 5.00;
            }
            Console.WriteLine($"Total Price:{FormatDecimal(total)}");

            double GetDiscountPrice(int itemIndex)
            {
                return items[itemIndex] * (1 - discount[itemIndex]);
            }
            bool TotalMeetsMinimum()
            {
                return total >= minimumSpend;
            }
            string FormatDecimal(double input)
            {
                return input.ToString().Substring(0, 5);
            }
        }
    }
}
