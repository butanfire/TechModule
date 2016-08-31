using System;
using System.Linq;

namespace _1.Remove_Negatives_and_Reverse
{
    public class RemoveNegativesReverse
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            var output = numbers.Where(s => s >= 0).Reverse().ToList();

            Console.WriteLine(output.Count == 0 ? "empty" : string.Join(" ", output));
        }
    }
}
