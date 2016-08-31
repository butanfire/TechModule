namespace _7__Exchange_Variable_Values
{
    using System;

    public class ExchangeValues
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:\na = {0}\nb = {1}",a,b);

            a ^= b;
            b ^= a;
            a ^= b;

            Console.WriteLine("After:\na = {0}\nb = {1}", a, b);
        }
    }
}
