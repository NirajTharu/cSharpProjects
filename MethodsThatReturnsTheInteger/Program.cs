// Methods that returns an integer 
using System;
namespace IntegerReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            // $ 1 united states dollar is equal to 0.0071 Nepali Rupee
            // Rs 141.17 = $ 1
            double NRP = 111000;
            double USD = NRPtoUSD(NRP);
            Console.WriteLine($"NRP {NRP} = $ {USD} ");

            double NRPtoUSD(double NRP)
            {
                double rate = 0.0071;
                return (double)(rate * NRP);
            }
        }
    }
}