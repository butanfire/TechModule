namespace _25_MasterNumbers
{
    using System;
    using System.Linq;

    public class MasterNumbers
    {
        public static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            for (int i = 1; i <= range; i++)
            {
                if (SumOfDigits(i))
                {
                    if (IsPalindrome(i.ToString()))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        private static bool SumOfDigits(int digit)
        {
            int sum = 0;
            bool containsEvenDigit = false;
            while (digit > 0)
            {
                var temp = digit % 10;

                if (temp % 2 == 0)
                {
                    containsEvenDigit = true;
                }

                sum += temp;
                digit /= 10;
            }

            return sum % 7 == 0 && containsEvenDigit;
        }

        private static bool IsPalindrome(string digit)
        {
            string result = string.Empty;
            foreach (var c in digit.Reverse())
            {
                result = result + c;
            }

            return result == digit;
        }
    }
}
