using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterMax = 100;

            Fibonacci(counterMax);
        }

        public static ulong Fibonacci(int counterMax)
        {
            ulong firstNumber = 0;
            ulong secondNumber = 1;

            for(int counter = 0; counter < counterMax; counter++)
            {
                Console.WriteLine("{0,3}: {1}", counter, firstNumber);
                ulong temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber += temp;
            }

            return firstNumber;
        }
    }
}


