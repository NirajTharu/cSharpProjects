// About the switch case 

/*The switch is best used when:

You have a single value (variable or expression) that you want to match against many possible values.
For any given match, you need to execute a couple of lines of code at most.
*/
using System;
namespace SwithCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeLevel = 50;
            string employeeName = "john Smith";
            string title = "";

            switch (employeeLevel)
            {
                case 50:
                case 100:
                    title = "Juinor Associate";
                    break;
                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senior Manager";
                    break;
                default:
                    title = "Associate";
                    break;
            }
            Console.WriteLine($"The post of the {employeeName} is {title}.");
        }
    }
}