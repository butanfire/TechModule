namespace _24_PrimesInRange
{
    using System;
    using System.Collections.Generic;

    public class PrimesInRange
    {
        public static void Main(string[] args)
        {

            long start = long.Parse(Console.ReadLine());
            long end = long.Parse(Console.ReadLine());

            List<long> output = FindPrimesInRange(start, end);

            if (output.Count > 0)
            {
                Console.WriteLine(string.Join(", ", output));
            }
        }

        static List<long> FindPrimesInRange(long startNum, long endNum)
        {
            List<long> numbers = new List<long>();
            for (long i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    numbers.Add(i);
                }
            }

            return numbers;
        }

        public static bool IsPrime(long num)
        {
            long counter = (long)Math.Sqrt(num);
            bool isPrime = true;

            if (num > 1)
            {
                for (int cnt = 2; cnt <= counter; cnt++)
                {
                    if (num % cnt == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            else
            {
                isPrime = false;
            }

            return isPrime;
        }
    }
}
