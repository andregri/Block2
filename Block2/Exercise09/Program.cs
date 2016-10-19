using System;
using System.Linq;

namespace Exercise9
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int[] findLongestIncreasingSequence(int[] array)
        {
            int[] lengthArray = findLengthIncreasingSequence(array);

            int maxLen = lengthArray.Max();

            //There may be more than one longest increasing sequence.
            //Because the exercise doesn't provide any related specs, 
            //we return the first sequence looping array from 0 to array.Length
            int[] longest = new int[maxLen];

            //it's the last found number of the longest sequence
            int previous = Int32.MaxValue;

            for (int len = maxLen; len >= 1; len--)
            {
                //search the len-th element in the longest sequence
                for (int i = 0; i < array.Length; i++)
                {
                    int current = array[i];

                    //if the number is the len-th in array and it's smaller than previous
                    //(because we're looking for the longest INCREASING sequence)
                    if (lengthArray[i] == len && current < previous)
                    {
                        longest[len - 1] = current;
                        previous = current;
                        break;
                    }
                }
            }

            return longest;
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
