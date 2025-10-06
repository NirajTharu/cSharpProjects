
// Conditional Operator
using System;
namespace ConditionlOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int salesAmount = 1000;
            // int discount = salesAmount > 1000 ? 100 : 50;
            // Console.WriteLine($"The discount Amount is: {discount}");
            Console.WriteLine($"The discount amount is: {(salesAmount > 1000 ? 100 : 50)}");
        }
    }
}
