namespace _02.Reverse_an_Array_of_Integers
{
    using System;
    using System.Collections.Generic;

    public class ReverseArray
    {
        public static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < inputLines; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            numbers.Reverse();
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
