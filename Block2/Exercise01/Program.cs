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
                    Console.WriteLine("Max is: " + GetMax(firstInput, secondInput));
                    Console.WriteLine("Min is: " + GetMin(firstInput, secondInput));
                    Console.WriteLine("\n\nPlease enter two integer number");
                }

                Console.WriteLine("Error. Please enter two INTEGER number");
            }
        }

        public static int GetMin(int firstNumber, int secondNumber)
        {
            int diff = firstNumber - secondNumber;
            int sgn = (diff >> 31) & 0x1;
            int min = secondNumber + (sgn * diff);

            return min;
        }

        public static int GetMax(int firstNumber, int secondNumber)
        {

            int diff = firstNumber - secondNumber;                      // the difference is negative if 'firstNumber' < 'secondNumber'
            int sgn = (diff >> 31) & 0x1;                               // check if the value of 'diff' is negative(?)
            int max = firstNumber - (sgn * diff);                       // if 'firstNumber' < 'secondNumber' , then 'sgn' is equal to 1 and 
                                                                        // so (sgn * diff ) = (firstNumber - secondNumber)
            return max;
        }
    }
}
