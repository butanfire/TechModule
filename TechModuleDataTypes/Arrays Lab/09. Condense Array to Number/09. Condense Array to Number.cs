namespace _09.Condense_Array_to_Number
{
    using System;
    using System.Linq;

    public class CondenseArrayToNumber
    {
        public static void Main(string[] args)
        {
            int[] numberArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (numberArray.Length > 1)
            {
                int[] condensed = new int[numberArray.Length - 1];
                for (int i = 0; i < numberArray.Length - 1; i++)
                {
                    condensed[i] = numberArray[i] + numberArray[i + 1];
                }

                numberArray = condensed;
            }

            Console.WriteLine(numberArray[0]);
        }
    }
}

