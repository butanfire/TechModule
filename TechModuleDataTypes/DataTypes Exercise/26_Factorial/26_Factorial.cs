namespace Factorial
{
    using System;
    using System.Numerics;
    public class Factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger[] factorial = new BigInteger[n + 1]; //array for holding all the factorial numbers
            factorial[0] = 1; //initialize the first number
            for (int i = 1; i < n + 1; i++)
            {
                factorial[i] = i * factorial[i - 1]; // calculate factorial

            }

            Console.WriteLine(factorial[n]); //output
        }
    }
}
