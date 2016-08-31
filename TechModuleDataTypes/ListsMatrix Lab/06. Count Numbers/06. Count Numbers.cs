using System;
using System.Linq;

namespace _07.Count_Numbers
{
    public class CountNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers.Sort(); //sorting the array and counting the occurrences of each number. The duplicate numbers will be next to each other.
            int occurences = 1;
            int nextNumber = 0;
            
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                nextNumber = numbers[i + 1];
                int currentNumber = numbers[i];
                if (nextNumber == currentNumber)
                {
                    occurences++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", currentNumber, occurences);
                    occurences = 1;
                }
            }

            //the last iteration is skipped
            Console.WriteLine("{0} -> {1}", nextNumber, occurences);
        }
    }
}

