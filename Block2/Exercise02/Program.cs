using System;

/*
 * Program to calculate the first 100 number of Fibonacci series.
 * To debug we used "http://www.readme.it/libri/M/M00101.shtml"
 */

namespace Exercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int counterMax = 100;

            Fibonacci(counterMax);
        }

        public static ulong Fibonacci(int counterMax)
        {
            ulong first = 0;
            ulong second = 1;
            ulong sum = 0;

            Console.Write("{0,3}: {1}\n", 0, first);
            Console.Write("{0,3}: {1}\n", 1, second);

            for (int counter = 2; counter < counterMax; counter++)
            {
                sum = first + second;
                Console.Write("{0,3}: {1}\n", counter, sum);
                first = second;
                second = sum;
            }

            //return the last sum for debugging purpose
            return sum;
        }
    }
}


