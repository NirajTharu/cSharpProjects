// Removing the code block form the if Statement 

using System;
namespace RemvoeBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            // if (flag)
            // {
            //     Console.WriteLine(flag);
            // }

            // if (flag)
            //     Console.WriteLine(flag);

            if (flag) Console.WriteLine(flag);

            string name = "steve";
            if (name == "bob") Console.WriteLine("Found Bob");
            else if (name == "steve") Console.WriteLine("Found Steve");
            else Console.WriteLine("Found Chuck");

            // 
            
            // if (name == "bob")
            //     Console.WriteLine("Found Bob");
            // else if (name == "steve")
            //     Console.WriteLine("Found Steve");
            // else
            //     Console.WriteLine("Found Chuck");
        }
    }
}