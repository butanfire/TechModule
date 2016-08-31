namespace _21_NumbersReversed
{
    using System;
    using System.Linq;

    public class NumbersReversed
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            Console.WriteLine(string.Join("",input.Reverse()));
        }
    }
}
