using System;
using System.Diagnostics;
using RandomGenerator;

namespace CSSortBuiltin
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 1000000;
            var a = new int[n];
            RandomNumber.Generate(a, 1);
            Stopwatch stopwatch = Stopwatch.StartNew();
            Array.Sort(a);
            stopwatch.Stop();
            var elapsed = stopwatch.Elapsed.TotalSeconds;
            Console.WriteLine("{0}sec. elapsed.", elapsed);
        }
    }
}
