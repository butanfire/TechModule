using System;
using System.Linq;

namespace _07.Matrix_Generator
{
    public class MatrixGenerator
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(' ').ToArray();

            int rows = int.Parse(command[1]);
            int cols = int.Parse(command[2]);

            int[,] matrix = new int[rows, cols];

            switch (command[0])
            {
                case "A":
                    matrix = CreateTypeA(matrix, rows, cols); //top bottom
                    break;
                case "B":
                    matrix = CreateTypeB(matrix, rows, cols); //snake type
                    break;
                case "C":
                    matrix = CreateTypeC(matrix, rows, cols); //diagonal type
                    break;
                case "D":
                    matrix = CreateTypeD(matrix, rows - 1, cols - 1); //spiral type
                    break;
            }

            PrintMatrix(matrix, rows, cols);
        }

        private static int[,] CreateTypeD(int[,] matrix, int rows, int cols)
        {
            int iterator = 1;
            int curRow = 0;
            int curCol = 0;
            int offset = 0;
            int dimensions = (rows + 1) * (cols + 1);
            bool condition = iterator <= dimensions;
            while (condition)
            {
                bool goRight = true, goDown = true, goUp = true, goLeft = true;
                while (goDown && condition)
                {
                    matrix[curRow++, curCol] = iterator++;
                    goDown = curRow < rows - offset;
                    condition = iterator <= dimensions;
                }


                while (goRight && condition)
                {
                    matrix[curRow, curCol++] = iterator++;
                    goRight = curCol < cols - offset;
                    condition = iterator <= dimensions;
                }


                while (goUp && condition)
                {
                    matrix[curRow--, curCol] = iterator++;
                    goUp = curRow > 0 + offset;
                    condition = iterator <= dimensions;
                }

                offset++;

                while (goLeft && condition)
                {
                    matrix[curRow, curCol--] = iterator++;
                    goLeft = curCol > 0 + offset;
                    condition = iterator <= dimensions;
                }
            }

            return matrix;
        }

        private static int[,] CreateTypeC(int[,] matrix, int rows, int cols)
        {
            int iterator = 1;

            for (int i = rows - 1; iterator <= rows * cols; i--)
            {
                for (int row = i, col = 0; row < rows; row++, col++)
                {
                    if (row >= 0 && col >= 0 && row < rows && col < cols)
                    {
                        matrix[row, col] = iterator++;
                    }
                }
            }

            return matrix;
        }

        private static int[,] CreateTypeB(int[,] matrix, int rows, int cols)
        {
            int iterator = 1;

            for (int i = 0; i < cols; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        matrix[j, i] = iterator++;
                    }
                }
                else
                {
                    for (int j = rows - 1; j >= 0; j--)
                    {
                        matrix[j, i] = iterator++;
                    }
                }
            }

            return matrix;
        }

        private static int[,] CreateTypeA(int[,] matrix, int rows, int cols)
        {
            int iterator = 1;

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    matrix[j, i] = iterator++;
                }
            }

            return matrix;
        }


        private static void PrintMatrix(int[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
