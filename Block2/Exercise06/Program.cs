using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string decimalToBinary(int number)
        {
            string bin = Convert.ToString(number, 2);
            return bin;
        }


        public static int binaryToDecimal(string number)
        {
            int dec = Convert.ToInt32(number, 2);
            return dec;
        }

        public static
    }
}
