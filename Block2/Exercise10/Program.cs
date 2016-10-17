using System;

namespace Exercise10
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int[,] initMatrixB(int size)
        {
            int[,] matrix = new int[size, size];

            int row = 0;
            int col = 0;

            //decide if increasing(1) or decreasing(-1) row
            int flag = 1;

            for (int element = 0; element < size * size; element++)
            {
                matrix[row, col] = element + 1; //assign values from 1

                row += flag;

                if (row == size || ((row == -1) && (col != 0)))
                {
                    //pass to the next column
                    col++;

                    //invert direction of assigning values to rows
                    flag *= -1;

                    //avoid array bound exception 
                    row += flag;

                    /*
                    if (row == size)
                    {
                        row--;
                    }
                    else
                    {
                        row++;
                    }*/
                }
            }

            return matrix;
        }

        public static void printMatrix(int[,] matrix)
        {
            if (matrix == null)
            {
                return;
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
