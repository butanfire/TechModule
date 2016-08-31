namespace _22_Fibonachi
{
    using System;

    public class Fibonachi
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateFibonachi(input));
        }

        public static int CalculateFibonachi(int n)
        {
            int fib0 = 0;
            int fib1 = 1;
            int sum = fib0 + fib1;

            while (n--> 0)
            {   
                fib0 = fib1;
                fib1 = sum;
                sum = fib0 + fib1;
            }

            return fib1;
        }
    }
}
