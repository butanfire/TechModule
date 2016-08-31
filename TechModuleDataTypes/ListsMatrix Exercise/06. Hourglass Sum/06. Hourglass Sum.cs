using System;
using System.Linq;

namespace _07.Hourglass_Sum
{
    public class HourglassSum
    {
        static void Main(string[] args)
        {
            int rows = 6, cols = 6;
            int[][] matrix = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            int sum = 0;
            int maxSum = int.MinValue;

            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < cols - 2; j++)
                {
                    for (int subi = i; subi <= i + 2; subi += 2) //body of the hourglass
                    {
                        for (int subj = j; subj <= j + 2; subj++)
                        {
                            sum += matrix[subi][subj];
                        }
                    }

                    sum += matrix[i + 1][j + 1]; //middle element of the hourglass

                    if (maxSum <= sum)
                    {
                        maxSum = sum;
                    }

                    sum = 0;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
