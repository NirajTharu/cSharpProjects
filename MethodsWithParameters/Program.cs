// Method with Parameters
using System;
namespace ParameterInFunctionCall
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] schedule = { 800, 1200, 1600, 2000 };
            DisplayAdjustedTimes(schedule, 6, -6);
            void DisplayAdjustedTimes(int[] times, int currentGTM, int newGTM)
            {
                int diff = 0;
                if (Math.Abs(newGTM) > 12 || Math.Abs(currentGTM) > 12)
                {
                    Console.WriteLine("Invalid GTM");
                }
                else if (newGTM <= 0 && currentGTM <= 0 || newGTM >= 0 && currentGTM >= 0)
                {
                    diff = 100 * Math.Abs(newGTM) - Math.Abs(currentGTM);
                }
                else
                {
                    diff = 100 * (Math.Abs(newGTM) + Math.Abs(currentGTM));
                }
                for (int i = 0; i < times.Length; i++)
                {
                    int newTime = (times[i] + diff) % 2400;
                    Console.WriteLine($"{times[i]} -> {newTime}");
                }
            }
        }
    }
}