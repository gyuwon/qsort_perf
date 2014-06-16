using System;
using System.Diagnostics;
using System.Linq;
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

        static void QuicksortThreeway(int[] a, int start, int end)
        {
            if (end - start < 2)
            {
                return;
            }
            int p = a[start + (end - start) / 2];
            int l = start;
            int r = end - 1;
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
                int t = a[l];
                a[l] = a[r];
                a[r] = t;
                ++l;
                --r;
            }
            QuicksortThreeway(a, start, r + 1);
            QuicksortThreeway(a, r + 1, end);
        }

        static void Main(string[] args)
        {
            var n = 1000000;
            var a = new int[n];
            var threeway = args.Contains("threeway", StringComparer.OrdinalIgnoreCase);
            var builtin = args.Contains("builtin", StringComparer.OrdinalIgnoreCase);
            var iter = 12;
            var trim = 1;
            var elapsed = new double[iter];
            for (int i = 0; i < iter; i++)
            {
                elapsed[i] = Run(a, new Random().Next(), threeway, builtin);
            }
            Array.Sort(elapsed);
            var mean = elapsed.Skip(trim).Take(iter - trim * 2).Average();
            Console.WriteLine("{0} ms elapsed.", mean);
        }

        private static double Run(int[] a, int seed, bool threeway, bool builtin)
        {
            RandomNumber.Generate(a, seed);
            var stopwatch = default(Stopwatch);
            if (threeway)
            {
                stopwatch = Stopwatch.StartNew();
                QuicksortThreeway(a, 0, a.Length);
            }
            else if (builtin)
            {
                stopwatch = Stopwatch.StartNew();
                Array.Sort(a);
            }
            else
            {
                stopwatch = Stopwatch.StartNew();
                Quicksort(a, 0, a.Length);
            }
            stopwatch.Stop();
            var elapsed = stopwatch.Elapsed.TotalMilliseconds;
            if (IsSorted(a) == false)
            {
                throw new InvalidOperationException("Not sorted!");
            }
            return elapsed;
        }

        private static bool IsSorted(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
