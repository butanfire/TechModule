namespace _23_PrimeChecker
{
    using System;

    public class PrimeChecker
    {
        public static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }

        public static bool IsPrime(long num)
        {
            long counter = (long) Math.Sqrt(num);
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
