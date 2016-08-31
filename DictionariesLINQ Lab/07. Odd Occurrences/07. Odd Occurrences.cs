namespace _07.Odd_Occurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddOccurrences
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLowerInvariant().Split(' ').ToArray();
            Dictionary<string, int> wordDictionary = new Dictionary<string, int>();

            foreach (string word in input)
            {
                if (wordDictionary.ContainsKey(word))
                {
                    wordDictionary[word] += 1;
                }
                else
                {
                    wordDictionary.Add(word, 1);
                }
            }

            var outputList = (from candidatePair in wordDictionary where candidatePair.Value % 2 == 1 select candidatePair.Key).ToList();

            Console.WriteLine(string.Join(", ", outputList));
        }
    }
}
