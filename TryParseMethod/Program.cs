// The TryParse Method 
using System;
namespace TryPrarsMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // String into an int
            // This is one of the exception exception

            // string name = "Niraj Kumar Chaudhary.";
            // Console.WriteLine(int.Parse(name));

            string Value = "102";
            // for the else value
            // string Value = "bad";
            int result = 0;
            if (int.TryParse(Value, out result))
            {
                Console.WriteLine($"Measurement is {result}");
            }
            else
            {
                Console.WriteLine("Unable to report the measurment.");
            }
            // The value of the TryParse() can be used outside the declared field
            if (result > 50)
                Console.WriteLine($"Measurement (w/ offset): {50 + result}");
        }
    }
}