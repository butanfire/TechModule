namespace _5_SpecialNumbers
{
    using System;

    public class SpecialNumbers
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                bool special = false;
                int num = i;
                int tempSum = 0;
                while (num > 0)
                {
                    int lastDigit = num % 10;
                    tempSum += lastDigit;
                    num /= 10;
                }

                if (tempSum == 5 || tempSum == 7 || tempSum == 11)
                {
                    special = true;
                }

                Console.WriteLine("{0} -> {1}", i, special);
            }
        }
    }
}
