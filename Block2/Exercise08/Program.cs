using System;

namespace Exercise8
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int greatestCommonDivisor(int a, int b)
        {
            if (b == 0)
            {
                return a;
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

        public static int leastCommonDivisor(int a, int b)
        {
            return Math.Abs(a * b) / greatestCommonDivisor(a, b);
        }
    }
}
