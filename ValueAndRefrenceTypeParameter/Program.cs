// Use of the value and refrence type parameter
using System;
using System.Security.Principal;
namespace ValueAndRefrenceTypeParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test passed by the value
            int a = 5;
            int b = 4;
            int c = 0;
            Multiply(a, b, c);
            Console.WriteLine($"Global statement is: {a} X {b} = {c}");

            void Multiply(int a, int b, int c)
            {
                c = a * b;
                Console.WriteLine($"Inside the multiply method: {a} X {b} = {c}");
            }


            // Test pass by Refrence
            int[] array = { 1, 2, 3, 4, 5 };
            printArray(array);
            Clear(array);
            printArray(array);

            void printArray(int[] array)
            {
                foreach (int a in array)
                {
                    Console.Write($"{a} ");
                }
                Console.WriteLine();
            }
            void Clear(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = 0;
                }
            }

            // Testing with String
            string status = "Healthy";
            Console.WriteLine($"Start: {status}");
            setHealth(false);
            Console.WriteLine($"End: {status}");
            void setHealth(bool isHealthy)
            {
                status = (isHealthy ? "Healthy" : "Unhealthy");
                Console.WriteLine($"Middle: {status}");
            }
        }
    }
}