// Integral value of unSigned integral data
using System;
namespace UnsingedIntegral
{
    class Progarm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unsigned Integral Types:");

            Console.WriteLine($"byte {byte.MinValue} to {byte.MaxValue} ");
            Console.WriteLine($"ushort{ushort.MinValue} to {ushort.MaxValue} ");
            Console.WriteLine($"uint {uint.MinValue} to {uint.MaxValue} ");
            Console.WriteLine($"ulong {ulong.MinValue} to {ulong.MaxValue} ");
        }
    }
}