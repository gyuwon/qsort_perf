using System;
using RandomGenerator;

namespace CSSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 10;
            var a = new int[n];
            RandomNumber.Generate(a, 1);
            foreach (var e in a)
            {
                Console.WriteLine(e);
            }
        }
    }
}
