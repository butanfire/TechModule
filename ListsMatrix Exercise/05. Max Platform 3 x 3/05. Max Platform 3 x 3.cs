using System;
using System.Linq;

namespace _05.Max_Platform_3_x_3
{
    public class MaxPlatform3x3
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            if (rows < 3 || cols < 3)
            {
                System.Environment.Exit(0);
            }

            decimal[][] matrix = new decimal[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            }

            var outputMatrix = FindSum(matrix, rows, cols);

            Print3x3Matrix(outputMatrix);
        }

        private static decimal[,] FindSum(decimal[][] matrix, int rows, int cols)
        {
            decimal sum = 0;
            decimal maxSum = decimal.MinValue;
            decimal[,] temp = new decimal[3, 3];

            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < cols - 2; j++)
                {
                    //for every row/col try to fit a 3x3 matrix
                    for (int subi = i; subi <= i + 2; subi++)
                    {
                        for (int subj = j; subj <= j + 2; subj++)
                        {
                            sum += matrix[subi][subj];
                        }
                    }
                    //collect the sum and check whether it is maximum. Also keep the numbers in a temp Array, which make the sum.
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        for (int row = 0, subi = i; row < 3; row++, subi++)
                        {
                            for (int col = 0, subj = j; col < 3; col++, subj++)
                            {
                                temp[row, col] = matrix[subi][subj];
                            }
                        }
                    }

                    sum = 0;
                }
            }

            Console.WriteLine(maxSum);

            return temp;
        }

        private static void Print3x3Matrix(decimal[,] temp)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", temp[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
