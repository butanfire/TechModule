using System;
using System.Linq;

namespace _03.Diagonal_Difference
{
    public class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int[][] matrix = new int[lines][];
            for (int i = 0; i < lines; i++)
            {
                var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                matrix[i] = new int[numbers.Count];
                for (int j = 0; j < numbers.Count; j++)
                {
                    matrix[i][j] = numbers[j];
                }
            }

            int sumFirstDiagonal = 0;
            int sumSecondDiagonal = 0;

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (i == j)
                    {
                        sumFirstDiagonal += matrix[i][j];
                    }
                    
                    if (j == matrix[i].Length - 1 - i)
                    {
                        sumSecondDiagonal += matrix[i][j];
                    }
                }
            }

            Console.WriteLine(Math.Abs(sumFirstDiagonal - sumSecondDiagonal));
        }
    }
}
