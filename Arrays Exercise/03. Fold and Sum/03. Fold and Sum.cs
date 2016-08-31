namespace _03.Fold_and_Sum
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4;
            int[] firstRow = numbers.Take(k).Reverse().Union(numbers.Reverse().Take(k)).ToArray();
            int[] secondRow = numbers.Skip(k).Take(2 * k).ToArray();
            int[] sum = new int[k * 2];
            for (int i = 0; i < 2 * k; i++)
            {
                sum[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
