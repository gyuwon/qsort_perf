﻿using System;
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

        static void Main(string[] args)
        {
            var n = 1000000;
            var a = new int[n];
            RandomNumber.Generate(a, seed: 1);
            var stopwatch = default(Stopwatch);
            if (args.Contains("builtin", StringComparer.OrdinalIgnoreCase))
            {
                stopwatch = Stopwatch.StartNew();
                Array.Sort(a);
            }
            else
            {
                stopwatch = Stopwatch.StartNew();
                Quicksort(a, 0, n); 
            }
            stopwatch.Stop();
            var elapsed = stopwatch.Elapsed.TotalSeconds;
            if (IsSorted(a) == false)
            {
                throw new InvalidOperationException("Not sorted!");
            }
            Console.WriteLine("{0} sec elapsed.", elapsed);
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
