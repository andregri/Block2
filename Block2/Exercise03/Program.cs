﻿using System;

namespace Exercise3
{
    public class Program
    {
        static void Main(string[] args)
        {
            double firstCoefficient, secondCoefficient, knownTerm;

            while (true)
            {
                do
                {
                    Console.Write("Please enter the coefficient of x^2: ");
                } while (!Double.TryParse(Console.ReadLine(), out firstCoefficient));

                do
                {
                    Console.Write("Please enter the coefficient of x^1: ");
                } while (!Double.TryParse(Console.ReadLine(), out secondCoefficient));

                do
                {
                    Console.Write("Please enter the coefficient of known term: ");
                } while (!Double.TryParse(Console.ReadLine(), out knownTerm));

                solveQuadraticEq(firstCoefficient, secondCoefficient, knownTerm);
            }
        }

        public static void solveQuadraticEq(double a, double b, double c)
        {
            double firstRoot, secondRoot;

            double discriminant = getDiscriminant(a, b, c);
            if (discriminant > 0)
            {
                firstRoot = (-b + Math.Sqrt(discriminant)) / (2 * a);
                secondRoot = (-b - Math.Sqrt(discriminant)) / (2 * a);

                Console.WriteLine("Real solution are: {0:f4} or {1:f4}", firstRoot, secondRoot);
            }

            else
            {
                Console.WriteLine("Equation hasn't real solution");
            }
        }

        // creating for debugging purpose 
        public static double getDiscriminant(double a, double b, double c)
        {
            return ((b * b) - (4 * a * c));
        }
    }
}
