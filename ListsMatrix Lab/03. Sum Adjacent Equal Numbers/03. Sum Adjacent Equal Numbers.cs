using System;
using System.Linq;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    public class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i + 1] *= 2; //as they are equal, we just multiply by 2
                    numbers.RemoveAt(i); //remove the element
                }
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
