using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int counterMax = 100;
            ulong firstNumber = 0;
            ulong secondNumber = 1;

            Fibonacci(counter, counterMax, firstNumber, secondNumber);
        }

        public static void Fibonacci(int counter, int counterMax, ulong previousNumber, ulong number)
        {
            ulong sum = number + previousNumber;
            Console.Write("{0,3}: {1}\n", counter,sum);
            if (counter < counterMax)
            {
                Fibonacci(++counter,counterMax, number, sum);
            }
        }
    }
}


