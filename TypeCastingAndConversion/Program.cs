// About the type casting and conversion
using System;
using System.IO.Pipelines;
namespace TypeCastingAndConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 2;
            string second = "4";
            string result = first + second;
            Console.WriteLine(result);


            // Decimal to int
            decimal myDecimal = 3.14m;
            Console.WriteLine($"decimal: {myDecimal}");
            int myInt = (int)myDecimal;
            Console.WriteLine($"int: {myInt}");

            // narrowing conversion
            decimal myDecimal1 = 1.23456789m;
            float myFloat = (float)myDecimal1;
            Console.WriteLine($"Decimal: {myDecimal1}");
            Console.WriteLine($"Float  : {myFloat}");

            // use ToString() function to convert a number to a string()
            int first_number = 7;
            int second_number = 8;
            string Total = first_number.ToString() + second_number.ToString();
            Console.WriteLine(Total);

            // Convert  a string to an integer using Parse() helper method
            // If the value of one contains the value which is not converted to the intiger then we should use TryParse() method for better result 

            string one = "88";
            string two = "7";
            int total = int.Parse(one) + int.Parse(two);
            Console.WriteLine(total);

            // Convert a string to a int using the Convert Class
            string value1 = "5";
            string value2 = "7";
            int resulatant = Convert.ToInt32(value1) + Convert.ToInt32(value2);
            Console.WriteLine(resulatant);


            Console.WriteLine("Compare casting and converting a decimal into an int");
            int valueone = (int)1.5m; //Casting truncate
            Console.WriteLine(valueone);

            int valuetwo = Convert.ToInt32(1.5m); //Converting rounds up
            Console.WriteLine(valuetwo);
        }
    }
}