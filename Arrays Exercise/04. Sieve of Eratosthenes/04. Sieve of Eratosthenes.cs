namespace _04.Sieve_of_Eratosthenes
{
    using System;

    public class SieveEratosthenes
    {
        public static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());

            bool[] primes = new bool[maxNumber * maxNumber];

            for (int i = 2; i < primes.Length - 1; i++) //mark all numbers as primes
            {
                primes[i] = true;
            }
            
            for (int i = 0; i <= maxNumber; i++)
            {
                if (primes[i]) //if it is a prime
                {
                    Console.Write(i + " ");
                    for (int j = 1; j < maxNumber; j++) //mark all numbers which are multiplied till maxNumber to false (because prime numbers do not have any products)
                    {
                        primes[i * j] = false;
                    }
                }
            }
        }
    }
}
