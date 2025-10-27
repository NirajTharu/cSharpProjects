// Understandin the Method scope
// Methods can not access the vraiable defined inside the another method.
using System;
using System.Net.NetworkInformation;
namespace MethodScope
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Jeena", "Ayesha", "Carlos", "Viktor" };
            DisplayStudents(students);
            DisplayStudents(new string[] { "Roberto", "Vaniya" });

            void DisplayStudents(string[] students)
            {
                foreach (string student in students)
                {
                    Console.Write($"{student}, ");
                }
                Console.WriteLine();
            }


            double pi = 3.14159;
            CirlceInfo(12);
            CirlceInfo(24);
            void PrintCircleArea(int radius)
            {
                double area = pi * (radius * radius);
                Console.WriteLine($"The area of the circle is {area}");
            }
            void PrintCircleCircumfrence(int radius)
            {
                double Circumfrance = 2 * pi * radius;
                Console.WriteLine($"Circumfrance of the Circle {Circumfrance}");
            }
            void CirlceInfo(int radius)
            {
                Console.WriteLine($"Circle with radus {radius}");
                PrintCircleArea(radius);
                PrintCircleCircumfrence(radius);
            }
        }
    }
}