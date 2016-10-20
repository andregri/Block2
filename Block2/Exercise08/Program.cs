using System;

namespace Exercise8
{
    public class Program
    {
        static void Main(string[] args)
        {
            int firstInput;
            int secondInput;

            Console.WriteLine("Please enter a integer number. Press ENTER; then enter another integer and re-press ENTER:");

            while (true)
            {               
                while ((int.TryParse(Console.ReadLine(), out firstInput)) && (int.TryParse(Console.ReadLine(), out secondInput)))
                {
                    if (firstInput == 0 && secondInput == 0)
                    {
                        Console.WriteLine("GCD is: " + 0);
                        Console.WriteLine("LCM is: " + 0);
                    }
                    else
                    {
                        Console.WriteLine("GCD is: " + greatestCommonDivisor(Math.Abs(firstInput), Math.Abs(secondInput)));
                        Console.WriteLine("LCM is: " + leastCommonMultiple(Math.Abs(firstInput), Math.Abs(secondInput)));
                        Console.WriteLine("\n\nPlease enter two integer number");
                    }
                    
                }

                Console.WriteLine("Error. Please enter two INTEGER number");

            }
        }

        public static int greatestCommonDivisor(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else if (a == 0)
            {
                return b;
            }
            else
            {
                if (a > b)
                {
                    return greatestCommonDivisor(a - b, b);
                }
                else
                {
                    return greatestCommonDivisor(a, b - a);
                }
            }
        }

        public static int leastCommonMultiple(int a, int b)
        {
            return Math.Abs(a * b) / greatestCommonDivisor(a, b);
        }
    }
}
