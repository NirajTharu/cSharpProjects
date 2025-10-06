// Exercise about the Code block and variable scope
using System;
namespace CodeBlockAndVariableScope
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int value = 0;
            if (flag)
            {

                Console.WriteLine($"Inside the code block: {value}");
            }
            value = 11;
            Console.WriteLine($"Outside the code block: {value}");
        }
    }
}