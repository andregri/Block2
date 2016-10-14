using System;

namespace Exercise3
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void solveQuadraticEq(double a, double b, double c)
        {
            double firstRoot, secondRoot;

            double discriminant = getDiscriminant(a, b, c);
            if (discriminant > 0)
            {
                // firstRoot, secondRoot;
            }

            else
            {

            }
        }

        // creating for debugging purpose 
        public static double getDiscriminant(double a, double b, double c)
        {
            return ((b * b) - (4 * a * c));
        }
    }
}
