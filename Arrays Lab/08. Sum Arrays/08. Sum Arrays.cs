namespace _08.Sum_Arrays
{
    using System;
    using System.Linq;

    public class SumArrays
    {
        public static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int lenFirstArray = firstArray.Length;
            int lenSecondArray = secondArray.Length;
            int max = Math.Max(firstArray.Length, secondArray.Length);
            int[] resultArray = new int[max];

            for (int i = 0; i < max; i++)
            {
                resultArray[i] = firstArray[i % lenFirstArray] + secondArray[i % lenSecondArray];
            }

            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}
