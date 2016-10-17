using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number;

            while (true)
            {
                do
                {
                    Console.WriteLine("Please enter a number. I'll convert it to word for you:");

                } while (!byte.TryParse(Console.ReadLine(), out number));

                Console.WriteLine("Number {0} to word is: " + numberToWords(number), number);
            }

        }

        public static string numberToWords(int number)
        {
            string word = "";

            if (number == 0)
                return "zero";

            /*			// if we want expand range from 1 to 1000000 
                        if ((number / 1000000) > 0 )
                        {
                            word += numberToWords(number / 1000000) + " million ";
                            number %= 1000000;
                        }

                        // if we want expand range from 1 to 1000
                        if ((number / 1000) > 0)
                        {
                            word += numberToWords(number / 1000) + " thousand ";
                            number %= 1000;

                        }
            */
            if ((number / 100) > 0)
            {
                word += numberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (word != "")
                    word += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };


                if (number < 20)
                    word += " " + unitsMap[number];

                else
                {
                    word += tensMap[number / 10];
                    if ((number % 10) > 0)
                        word += "-" + unitsMap[number % 10];
                }

            }


            return word;
        }
    }
}