namespace _07.Count_Real_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountRealNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            SortedDictionary<double,int> numberCounter = new SortedDictionary<double, int>();

            foreach (var number in input)
            {
                if (numberCounter.ContainsKey(number))
                {
                    numberCounter[number]++;
                }
                else
                {
                    numberCounter.Add(number,1);
                }
            }

            foreach (var valuePair in numberCounter)
            {
                Console.WriteLine("{0} -> {1}", valuePair.Key, valuePair.Value);
            }
        }
    }
}
