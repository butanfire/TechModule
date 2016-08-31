using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Square_Numbers
{
    public class SquareNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Trim().Split(' ').Select(long.Parse).ToList();

            List<long> squareNumbers = numbers.Where(number => IsSquare(number)).ToList();

            squareNumbers.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", squareNumbers));
        }

        public static bool IsSquare(long number)
        {
            long candidate = (long)Math.Floor(Math.Sqrt(number) + 0.5);
            return candidate * candidate == number;

        }
    }
}
