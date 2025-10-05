

using System;
namespace AdvanceInGrading
{
    class Program
    {
        static void Main(string[] args)
        {
            int marksObtain = 8;

            if (marksObtain >= 97 && marksObtain <= 100)
            {
                Console.WriteLine("A+");
            }
            else if (marksObtain >= 93 && marksObtain <= 96)
            {
                Console.WriteLine("A");
            }
            else if (marksObtain >= 90 && marksObtain <= 92)
            {
                Console.WriteLine("A-");
            }
            else if (marksObtain >= 87 && marksObtain <= 89)
            {
                Console.WriteLine("B+");
            }
            else if (marksObtain >= 83 && marksObtain <= 86)
            {
                Console.WriteLine("B");
            }
            else if (marksObtain >= 80 && marksObtain <= 82)
            {
                Console.WriteLine("B-");
            }
            else if (marksObtain >= 77 && marksObtain <= 79)
            {
                Console.WriteLine("C+");
            }
            else if (marksObtain >= 73 && marksObtain <= 67)
            {
                Console.WriteLine("C");
            }
            else if (marksObtain >= 70 && marksObtain <= 72)
            {
                Console.WriteLine("C-");
            }
            else if (marksObtain > 67 && marksObtain <= 69)
            {
                Console.WriteLine("D+");
            }
            else if (marksObtain >= 63 && marksObtain <= 66)
            {
                Console.WriteLine("D");
            }
            else if (marksObtain >= 60 && marksObtain <= 62)
            {
                Console.WriteLine("D-");
            }
            else if (marksObtain >= 0 && marksObtain <= 59)
            {
                Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine("Invalid Input makrs");
            }

        }


    }
}