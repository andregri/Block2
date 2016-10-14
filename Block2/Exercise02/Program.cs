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

        public static double Fibonacci(int counterMax)
        {
            double firstNumber = 0;
            double secondNumber = 1;
            double result = 0;

            Console.Write("{0,3}: {1}\n", 0, firstNumber);
            Console.Write("{0,3}: {1}\n", 1, secondNumber);

            for (int counter = 2; counter < counterMax; counter++)
            {
                result = firstNumber + secondNumber;
                Console.Write("{0,3}: {1}\n", counter, result);
                firstNumber = secondNumber;
                secondNumber = result;
            }

            //return the last number for debugging purpose
            return result;
        }
    }
}


