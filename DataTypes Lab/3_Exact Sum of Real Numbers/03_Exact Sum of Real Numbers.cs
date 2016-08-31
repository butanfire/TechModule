namespace _3_Exact_Sum_of_Real_Numbers
{
    using System;

    public class ExactSumRealNumbers
    {
        public static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            decimal sum = 0m;
            for (int i = 0; i < numbers; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
