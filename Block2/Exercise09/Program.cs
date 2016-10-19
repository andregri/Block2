using System;

namespace Exercise9
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int[] findLengthIncreasingSequence(int[] array)
        {
            int length = array.Length;
            int[] lengthArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                lengthArray[i] = 1;
            }

            for (int x = 1; x < length; x++)
            {
                for (int i = 0; i < x; i++)
                {
                    if (array[i] < array[x] && lengthArray[x] <= lengthArray[i])
                    {
                        lengthArray[x]++;
                    }
                }
            }

            return lengthArray;
        }
    }
}
