using System;

namespace Block2
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
                    Console.WriteLine("Max is: " + getMax(firstInput, secondInput));
                    Console.WriteLine("Min is: " + getMin(firstInput, secondInput));
                    Console.WriteLine("\n\nPlease enter two integer number");
                }

                Console.WriteLine("Error. Please enter two INTEGER number");

            }
        }

        public static int getMin(int a, int b)
        {
			try
			{
				int[] array = { a, b };
				int diff = a - b;
				int sign = diff / Math.Abs(diff);
				int index = (int)(0.5 + sign * 0.5);
				return array[index];
			}
			
			catch
			{
				print("Numbers are equal");
				return a;
			}
        }

        public static int getMax(int firstNumber, int secondNumber)
        {

            int diff = firstNumber - secondNumber;                      // the difference is negative if 'firstNumber' < 'secondNumber'
            int sgn = (diff >> 31) & 0x1;                               // check if the value of 'diff' is negative(?)
            int max = firstNumber - (sgn * diff);                       // if 'firstNumber' < 'secondNumber' , then 'sgn' is equal to 1 and 
                                                                        // so (sgn * diff ) = (firstNumber - secondNumber)
            return max;
        }
    }
}
