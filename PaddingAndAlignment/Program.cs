// Discovering padding and alignmnet in the C#
using System;
namespace PaddingAndAlignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Padding in the C# just make the given string of the input length
            string first = "Hi";
            Console.WriteLine(first.PadLeft(3, '*'));

            // Real use case of the padding
            string paymentID = "769C";
            string payeeName = "Mr. Stephen Strange";
            string paymentAmount = "$4,000,837";
            var foramttedLine = paymentID.PadLeft(6, '-');
            foramttedLine += payeeName.PadLeft(24);
            foramttedLine += paymentAmount.PadLeft(14);
            Console.WriteLine("12345678901234567890123456789012345678901234");
            Console.WriteLine(foramttedLine);

        }
    }
}