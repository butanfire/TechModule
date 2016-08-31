namespace _10.Pairs
{
    using System;
    using System.Linq;

    public class Pairs
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());
            int pairCounter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i + diff == numbers[j])
                    {
                        pairCounter++;
                    }
                }
            }

            Console.WriteLine(pairCounter);
        }
    }
}
