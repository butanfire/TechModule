namespace Problem_3.Target_Multiplier
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rows = indexes[0];
            int cols = indexes[1];
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            var targetCoords = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            MultiplyMatrix(matrix, targetCoords, rows, cols);
            PrintMatrix(matrix, rows, cols);

        }

        private static void MultiplyMatrix(int[,] matrix, int[] targetCoords, int rows, int cols)
        {
            int affectedRow = targetCoords[0];
            int affectedCol = targetCoords[1];
            int rowCounter = 0;
            int colCounter = 0;

            int sum = -matrix[affectedRow, affectedCol];

            for (int i = affectedRow - 1; rowCounter < 3 && affectedRow < rows; i++)
            {
                for (int j = affectedCol - 1; colCounter < 3 && affectedCol < cols; j++)
                {
                    sum += matrix[i, j];
                    colCounter++;
                }

                colCounter = 0;
                rowCounter++;
            }

            rowCounter = 0;

            for (int i = affectedRow - 1; rowCounter < 3 && affectedRow < rows; i++)
            {
                for (int j = affectedCol - 1; colCounter < 3 && affectedCol < cols; j++)
                {
                    if (i == affectedRow && j == affectedCol)
                    {
                        colCounter++;
                        continue;
                    }

                    matrix[i, j] *= matrix[affectedRow, affectedCol];
                    colCounter++;
                }

                colCounter = 0;
                rowCounter++;
            }

            matrix[affectedRow, affectedCol] *= sum;
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
