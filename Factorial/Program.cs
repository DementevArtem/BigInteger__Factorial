using System;
using System.Numerics;
using System.Threading;

namespace Factorial
{
    class Program
    {
        static BigInteger Factorial(int N) =>  N == 0 ? 1 : N * Factorial(N - 1);
        
        static void Main(string[] args)
        {
            var N = 0;
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("N = " + N);
                    Console.WriteLine("N = " + Factorial(N));
                    N++;
                    Thread.Sleep(10);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    break;
                }
            }
        }
    }
}
