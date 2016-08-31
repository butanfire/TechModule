namespace _02.Count_Letters_in_String
{
    using System;
    using System.Linq;

    public class CountLettersInString
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLowerInvariant();
            var size = input.Max() + 1;

            int[] array = new int[size];
            array.Initialize();

            foreach (char word in input)
            {
                array[word] += 1;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    var letter = (char) i;
                    Console.WriteLine("{0} -> {1}", letter, array[letter]);
                }
            }
        }
    }
}
