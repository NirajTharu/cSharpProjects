// About the string formatting basics in C#
using System;
using System.Diagnostics;
namespace StringFromatting
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Composite formatting uses numbered placeholders within a string. 
           At run time, everything inside the braces is resolved to a value that is also passed in based on their position.*/
            string first = "Hello";
            string second = "world";
            string result = string.Format("{0} {1}!", first, second);
            Console.WriteLine(result);

            // Formatting curriencies
            // This will atomatically add the currency according to the current location(country or region) and language of the end user.
            decimal price = 1003.5m;
            int discoutn = 50;
            Console.WriteLine($"Price {price:C} and discout {discoutn:C}");

            // Formatting Numbers
            // in the place of N if you write N4 it will display the precision upto 4 digits
            decimal measurement = 12345.67891m;
            Console.WriteLine($"Measurment is:{measurement:N} units.");

            // Formatting percentage
            // In the place of P if you wirte P2 it will display the Precision up to 2 digits and so on .
            decimal tax = .13m;
            Console.WriteLine($"The tax rate is: {tax:P}");

            // Combinning the formatting approach
            decimal pprice = 73.82m;
            decimal salesPrice = 60.43m;
            string yourDiscout = String.Format("You saved {0:C2} off the regular {1:C2} price.", (pprice - salesPrice), salesPrice);
            yourDiscout = yourDiscout + $" A discout of{((pprice - salesPrice) / pprice):P3}!";
            Console.WriteLine(yourDiscout);

        }
    }
}