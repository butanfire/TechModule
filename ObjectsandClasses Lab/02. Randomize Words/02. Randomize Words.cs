using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Randomize_Words
{
    public class RandomizeWords
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            string[] numbers = new string[input.Count]; //the new array to hold the randomized words
            Random rng = new Random();
            List<int> nums = new List<int>(input.Count);

            for (int i = 0; i < input.Count; i++)
            {
                var number = rng.Next(0, input.Count);
                
                while (nums.Contains(number)) //if the random number is already generated, generate a new one (to avoid duplication)
                {
                    number = rng.Next(0, input.Count);
                }
                
                numbers[i] = input[number]; //assign to each position in the new array, the random indexed from the source array.
                nums.Add(number);
            }

            Console.WriteLine(string.Join("\n", numbers));
        }
    }
}
