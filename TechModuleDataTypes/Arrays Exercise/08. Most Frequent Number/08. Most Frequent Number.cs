namespace _8.Most_Frequent_Number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MostFrequentNumber
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> existingNumbers = input.Distinct().ToList();
            int maxOccurrences = 1;
            int tempOccurrences = 1;
            int mostFreqNumber = 0;

            for (int i = 0; i < existingNumbers.Count; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (i == input[j])
                    {
                        maxOccurrences++;
                    }
                }

                if (maxOccurrences > tempOccurrences)
                {
                    mostFreqNumber = i;
                    tempOccurrences = maxOccurrences;
                }

                maxOccurrences = 1;
            }

            Console.WriteLine(mostFreqNumber);
        }
    }
}
