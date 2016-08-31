namespace _07.Rounding_Numbers_Away_from_Zero
{
    using System;
    using System.Linq;

    public class RoundNumbers
    {
        public static void Main(string[] args)
        {
            decimal[] numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            foreach (decimal number in numbers)
            {
                Console.WriteLine("{0} => {1}", number, Math.Round(number, MidpointRounding.AwayFromZero));
            }
        }
    }
}
