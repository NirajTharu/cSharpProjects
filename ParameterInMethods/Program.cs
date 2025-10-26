// Using the parameter in the Methods
using System;
namespace ParametersInMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            CountTo(5);
            void CountTo(int max)
            {
                for (int i = 0; i < max; i++)
                {
                    Console.Write($"{i}\t");
                }
            }
        }
    }
}