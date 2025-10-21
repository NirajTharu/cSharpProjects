// The remove and replace functions in this file
using System;
namespace RemoveAndReplaceFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "12345John Smith          5000  3  ";
            string updatedData = data.Remove(5, 20);
            Console.WriteLine(updatedData);

            string message = "This--is--ex-amp-le--da-ta";
            message = message.Replace("--", " ");
            message = message.Replace("-", "");
            Console.WriteLine(message);
        }
    }
}