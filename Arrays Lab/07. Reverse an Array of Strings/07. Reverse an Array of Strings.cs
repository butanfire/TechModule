namespace _07.Reverse_an_Array_of_Strings
{
    using System;
    using System.Linq;

    public class ReverseArray
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Console.WriteLine(string.Join(" ",input.Reverse()));
        }
    }
}
