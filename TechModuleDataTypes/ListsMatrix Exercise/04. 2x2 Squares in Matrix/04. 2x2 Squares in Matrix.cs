using System;
using System.Linq;

namespace _04._2x2_Squares_in_Matrix
{
    public class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = sizes[0];

            int squares = 0;

            string[][] matrix = new string[rows][]; //jagged array

            for (int i = 0; i < rows; i++)
            {

                matrix[i] = Console.ReadLine().Split(' ').ToArray();
            }

            squares = FindSquares(matrix, rows);
            Console.WriteLine(squares);
        }

        private static int FindSquares(string[][] matrix, int rows)
        {
            int squares = 0;

            for (int i = 0; i < rows - 1; i++)
            {
                int cols = matrix[i].Length;
                for (int j = 0; j < cols - 1; j++)
                {
                    string element00 = matrix[i][j];
                    string element01 = matrix[i][j + 1];
                    string element10 = matrix[i + 1][j];
                    string element11 = matrix[i + 1][j + 1];

                    if (element00 == element11 &&
                        element11 == element01 &&
                        element10 == element11 &&
                        element01 == element00)
                    {
                        squares++;
                    }
                }
            }

            return squares;
        }
    }
}
