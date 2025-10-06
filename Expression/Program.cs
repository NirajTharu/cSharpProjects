// About the expression in the C#

using System;
namespace expression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a" == "a");
            Console.WriteLine("a" == "A");
            Console.WriteLine(1 == 2);
            Console.WriteLine("a " == " A");

            string value1 = "a ";
            string value2 = " A";
            Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

            Console.WriteLine("a" != "a");
            Console.WriteLine("a" != "A");
            Console.WriteLine(1 != 2);

            string myvalue = "a";
            Console.WriteLine(myvalue != "a");


            string atoz = "The quick brown fox jump over the lazy dog.";
            Console.WriteLine(atoz);
            Console.WriteLine(atoz.Contains("fox"));
            Console.WriteLine(atoz.Contains("cow"));

            // logical Negation
            Console.WriteLine(atoz.Contains("fox") == false);
            Console.WriteLine(!atoz.Contains("cow"));

            // inequality operator versus logical negation
            Console.WriteLine("About the operators:");
            int a = 7;
            int b = 6;
            Console.WriteLine(a != b);
            string s1 = "Hello";
            string s2 = "Hello";
            Console.WriteLine(s1 != s2);
        }
    }
}