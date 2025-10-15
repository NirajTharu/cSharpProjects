// About the Value and Refrence type
using System;
using Microsoft.VisualBasic;
namespace ValueAndReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value type intiger
            int val_A = 3;
            int Val_B = val_A;
            Val_B = 4;
            Console.WriteLine($"--Value Types__");
            Console.WriteLine($"Value of A is {val_A}");
            Console.WriteLine($"Value of B is {Val_B}");

            // Value type Array
            int[] ref_A = new int[1];
            ref_A[0] = 2;
            int[] ref_B = ref_A;
            ref_B[0] = 5;
            Console.WriteLine("--RefrenceTypes--");
            Console.WriteLine($"ref_A {ref_A[0]}");
            Console.WriteLine($"ref_B {ref_B[0]}");
        }
    }
}