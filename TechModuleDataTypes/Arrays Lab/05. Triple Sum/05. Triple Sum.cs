namespace _05.Triple_Sum
{
    using System;
    using System.Linq;

    public class TripleSum
    {
        public static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool found = false;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int numberA = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    int numberB = array[j];
                    if (array.Contains(numberA + numberB))
                    {
                        Console.WriteLine("{0} + {1} == {2}", numberA, numberB, numberA + numberB);
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }
}
