namespace _03.Sum__Min__Max__First__Last__Average
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumMinMaxFirstLastAvg
    {
        public static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < inputLines; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            int sum = numbers.Sum();
            int max = numbers.Max();
            int min = numbers.Min();
            double avg = numbers.Average();
            int first = numbers.First();
            int last = numbers.Last();

            Console.WriteLine("Sum = {0}\nMin = {1}\nMax = {2}\nFirst = {3}\nLast = {4}\nAverage = {5}", sum, min, max, first, last, avg);
        }
    }
}
