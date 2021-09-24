using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace APA1
{
    class Program
    {
        public static ulong cont1, cont2, cont3;
        static ulong FibRec(ulong n)
        {
            cont1++;
            if (n == 1 || n == 0)
                return 1;
            else
                return FibRec(n - 1) + FibRec(n - 2);
        }

        static ulong FibLin(ulong n)
        {
            List<ulong> list = new List<ulong>() {1, 1};

            for (ulong i = 2; i <= n; i++)
            {
                cont2++;
                ulong x = list[(int)i - 1] + list[(int)i - 2];
                list.Add(x);
            }

            return list[(int)n];
        }

        static long FibFormula(ulong n)
        {
            cont3++;
            return (long) Math.Round(Math.Pow((1 + Math.Sqrt(5)) / 2, n + 1) / Math.Sqrt(5));
        }
        static void Main(string[] args)
        {
            ulong n = 60;

            DateTime start = new DateTime();
            DateTime end = new DateTime();

            Console.WriteLine("n = " + n);

            Console.WriteLine("Recursion:");
            start = DateTime.Now;
            Console.WriteLine("Result = " + FibRec(n));
            end = DateTime.Now;
            TimeSpan ts1 = (end - start);
            Console.WriteLine("Execution time = " + String.Format("{0:F10}", ts1.TotalSeconds));
            Console.WriteLine("Nr iterations = " + cont1);
            Console.WriteLine();

            Console.WriteLine("Linear:");
            start = DateTime.Now;
            Console.WriteLine("Result = " + FibLin(n));
            end = DateTime.Now;
            TimeSpan ts2 = (end - start);
            Console.WriteLine("Execution time = " + String.Format("{0:F10}", ts2.TotalSeconds));
            Console.WriteLine("Nr iterations = " + cont2);
            Console.WriteLine();

            Console.WriteLine("Formule:");
            start = DateTime.Now;
            Console.WriteLine("Result = " + FibFormula(n));
            end = DateTime.Now;
            TimeSpan ts3 = (end - start);
            Console.WriteLine("Execution time = " + String.Format("{0:F10}", ts3.TotalSeconds));
            Console.WriteLine("Nr iterations = " + cont3);
            Console.WriteLine();
        }
    }
}
