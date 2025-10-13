/* When you need a more precise answer, you should use decimal. 
Each value of type decimal has a relatively large memory footprint, 
however performing math operations gives you a more precise result. 
So, you should use decimal when working with financial data or 
any scenario where you need an accurate result from a calculation.*/

using System;
namespace FloatingPointData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Floating point types:");
            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
        }
    }
}