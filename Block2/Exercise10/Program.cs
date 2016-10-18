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

        public static int[,] initMatrixDiagonal(int size)
        {
            int[,] matrix = new int[size, size];
            int value = 1;
            
            //init left half of matrix
            int lCol = 0;

            for (int lRow = size - 1; lRow >= 0; lRow--)
            {
                int j = lRow; //temp index of rows

                //loop to assign values to the (size - row)-th diagonal
                for (int i = 0; i <= lCol;)
                {
                    matrix[j++, i++] = value++;
                }

                lCol++;
            }


            //init right half of matrix
            int rRow = size - 1;

            for (int rCol = 1; rCol < size; rCol++)
            {
                int j = rCol;

                for (int i = 0; i < rRow;)
                {
                    matrix[i++, j++] = value++;
                }

                rRow--;
            }

            return matrix;
        }

        public static int[,] initMatrixSpiral(int size)
        {
            int[,] matrix = new int[size, size];
            int el = 0;
            int colPos = 0;
            int rowPos = 0;
            int counter = 0;

            while (el < size * size)
            {
                el += goDown(matrix, colPos, rowPos, size - counter, el);
                rowPos += (size - counter - 1);
                colPos++;

                counter++;

                if (el == (size * size))
                {
                    break;
                }

                el += goRight(matrix, rowPos, colPos, size - counter, el);
                rowPos--;
                colPos += (size - counter - 1);

                if (el == (size * size))
                {
                    break;
                }

                el += goUp(matrix, colPos, rowPos, size - counter, el);
                colPos--;
                rowPos -= (size - counter - 1);

                counter++;

                if (el == (size * size))
                {
                    break;
                }

                el += goLeft(matrix, rowPos, colPos, size - counter, el);
                rowPos++;
                colPos -= (size - counter - 1);
            }

            return matrix;
        }

        public static int goDown(int[,] matrix, int col, int rowStart, int passes, int valueStart)
        {
            for (int p = rowStart; p < rowStart + passes; p++)
            {
                matrix[p, col] = valueStart++;
            }

            return passes;
        }

        public static int goRight(int[,] matrix, int row, int colStart, int passes, int valueStart)
        {
            for (int p = colStart; p < colStart + passes; p++)
            {
                matrix[row, p] = valueStart++;
            }

            return passes;
        }

        public static int goUp(int[,] matrix, int col, int rowStart, int passes, int valueStart)
        {
            for (int p = rowStart; p > rowStart - passes; p--)
            {
                matrix[p, col] = valueStart++;
            }

            return passes;
        }


        public static int goLeft(int[,] matrix, int row, int colStart, int passes, int valueStart)
        {
            for (int p = colStart; p > colStart - passes; p--)
            {
                matrix[row, p] = valueStart++;
            }

            return passes;
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
