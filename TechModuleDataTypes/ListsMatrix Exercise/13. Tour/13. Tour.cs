using System;
using System.Linq;

namespace _13.Tour
{
    public class Tour
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[][] matrix = new int[lines][];
            for (int i = 0; i < lines; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            var route = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = 0;
            sum += matrix[0][route[0]]; //get the value from the starting point

            for (int i = 0; i < route.Length - 1; i++)
            {
                int row = route[i];
                int col = route[i + 1];
                sum += matrix[row][col];
            }

            Console.WriteLine(sum);
        }
    }
}
