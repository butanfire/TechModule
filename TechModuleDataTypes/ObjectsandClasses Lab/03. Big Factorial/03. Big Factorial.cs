using System;
using System.Numerics;

namespace _03.Big_Factorial
{
    public class BigFactorial
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            BigInteger number = 1;
            BigInteger result = 1;

            for (int i = 1; i <= input; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
