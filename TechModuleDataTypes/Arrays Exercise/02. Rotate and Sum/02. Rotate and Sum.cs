namespace _02.Rotate_and_Sum
{
    using System;
    using System.Linq;

    public class RotateAndSum
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int[] sum = new int[numbers.Length];

            for (int i = 0; i < rotations; i++)
            {
                int lastElement = numbers.Last();
                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    sum[j] += numbers[j - 1];
                    numbers[j] = numbers[j-1];
                }

                sum[0] += lastElement;
                numbers[0] = lastElement;
            }

            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
