using System;

namespace Block2
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int getMin(int a, int b)
        {
            int[] array = { a, b };
            int diff = a - b;
            int sign = diff / Math.Abs(diff);
            int index = (int)(0.5 + sign * 0.5);
            return array[index];
        }

        static int getMax(int a, int b)
        {
            int[] array = { a, b };
            return array[(int)(0.5 - ((a - b) / Math.Abs(a - b)) * 0.5)];
        }
    }
}
