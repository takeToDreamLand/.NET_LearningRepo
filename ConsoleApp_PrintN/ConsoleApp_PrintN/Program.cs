using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp_PrintN
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //PrintN1(int.MaxValue);
            PrintN2(int.MaxValue);
            //PrintN2(10000);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.Read();
        }
        static void PrintN1(int N)
        {
            for (var i = 1; i < N; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void PrintN2(int N)
        {
            if (N !=0)
            {
                PrintN2(N - 1);
                Console.WriteLine(N);
            }
        }
    }
}
