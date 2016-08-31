using System;

namespace _09.RotateMatrix
{
    public class RotateMatrix
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            string[,] matrix = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            matrix = Rotate(matrix, rows, cols);
            PrintMatrix(matrix, rows, cols);
        }

        private static string[,] Rotate(string[,] matrix, int rows, int cols)
        {
            string[,] temp = new string[cols, rows];

            int newCol = 0, newRow = rows - 1;
            for (int i = 0; i < cols; i++, newCol++)
            {
                for (int j = 0; j < rows; j++, newRow--)
                {
                    temp[i, j] = matrix[newRow, newCol];
                }

                newRow = rows - 1;
            }

            return temp;
        }

        private static void PrintMatrix(string[,] matrix, int rows, int cols)
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
