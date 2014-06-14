using System;
using System.Diagnostics;
using RandomGenerator;

namespace CSSort
{
    class Program
    {
        static void Quicksort(int[] a, int start, int end)
        {
            if (end - start < 2)
            {
                return;
            }
            var p = a[start + (end - start) / 2];
            var l = start;
            var r = end - 1;
            while (l <= r)
            {
                if (a[l] < p)
                {
                    ++l;
                    continue;
                }
                if (a[r] > p)
                {
                    --r;
                    continue;
                }
                var t = a[l];
                a[l] = a[r];
                a[r] = t;
                ++l;
                --r;
            }
            Quicksort(a, start, r + 1);
            Quicksort(a, r + 1, end);
        }

        static void Main(string[] args)
        {
            var n = 1000000;
            var a = new int[n];
            RandomNumber.Generate(a, 1);
            Stopwatch stopwatch = Stopwatch.StartNew();
            Quicksort(a, 0, n);
            stopwatch.Stop();
            var elapsed = stopwatch.Elapsed.TotalSeconds;
            Console.WriteLine("{0}sec. elapsed.", elapsed);
        }
    }
}
