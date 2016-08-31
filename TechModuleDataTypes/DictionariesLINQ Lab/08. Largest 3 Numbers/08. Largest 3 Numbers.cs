namespace _08.Largest_3_Numbers
{
    using System;
    using System.Linq;

    public class Largest3Numbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var output = input.OrderByDescending(num => num).Take(3);

            Console.WriteLine(string.Join(" ",output));
        }
    }
}
