using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            double numerator;
            double denominator;

            Console.WriteLine("Please enter two number: N and X.\nI'll calculate for you 1 + 1!/X + 2!/X^2 + … + N!/X^N");
            Console.Write("N:");
            while (double.TryParse(Console.ReadLine(), out numerator))
            {
                Console.Write("X:");
                while (!double.TryParse(Console.ReadLine(), out denominator) || (denominator == 0))
                {
                    Console.WriteLine("\nError.Please enter a number!");
                    Console.Write("X:");
                }

                Console.WriteLine("Your sum is: " + getSum(numerator, denominator));
                Console.WriteLine("\nPlease enter two number: N and X.\nI'll calculate for you 1 + 1!/X + 2!/X^2 + … + N!/X^N");
                Console.Write("N:");
            }

        }

        public static double getSum(double firstNumber, double secondNumber)
        {
            double result = 1;
            int factorial = 1;
            for (int i = 1; i <= firstNumber; i++)
            {
                factorial = 1; 
                for (int j = i; j >= 1; j--)
                {
                    factorial *= j;
                }
                result += factorial / Math.Pow(secondNumber, i);
            }

            return result;
        }
    }
}
