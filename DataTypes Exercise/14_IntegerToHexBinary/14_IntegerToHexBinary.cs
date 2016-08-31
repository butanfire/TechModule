namespace _14_IntegerToHexBinary
{
    using System;

    public class IntegerToHex
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}\n{1}", Convert.ToString(number,16).ToUpper(), Convert.ToString(number,2));
        }
    }
}
