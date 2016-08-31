using System.Linq;

namespace _09.Index_of_Letters
{
    using System;

    public class IndexOfLetters
    {
        public static void Main(string[] args)
        {
            char[] letters = Console.ReadLine().ToLowerInvariant().ToCharArray();

            int diff = -97;

            foreach (var character in letters.Where(char.IsLetter))
            {
                Console.WriteLine("{0} -> {1}", character, (int)character + diff);
            }
        }
    }
}
