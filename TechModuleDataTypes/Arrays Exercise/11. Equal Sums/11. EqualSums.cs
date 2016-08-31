namespace _11.Equal_Sums
{
    using System;
    using System.Linq;

    public class Equal_Sums
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool indexFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int index = i;
                int sumLeft = 0;
                int sumRight = 0;
                for (int j = 0; j < index ; j++)
                {
                    sumLeft += numbers[j];
                }
                for (int s = index + 1; s < numbers.Length; s++)
                {
                    sumRight += numbers[s];
                }

                if (sumRight == sumLeft)
                {
                    Console.WriteLine(index);
                    indexFound = true;
                }
            }

            if (!indexFound)
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
