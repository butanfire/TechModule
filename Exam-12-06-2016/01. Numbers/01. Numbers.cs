namespace Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Numbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            numbers.Sort();
            List<decimal> output = new List<decimal>();
            var avg = numbers.Average();
            int counter = 0;

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] > avg && counter < 5)
                {
                    counter++;
                    output.Add(numbers[i]);
                }
            }

            Console.WriteLine(output.Count > 0 ? string.Join(" ", output.OrderByDescending(s => s)) : "No");
        }
    }
}
