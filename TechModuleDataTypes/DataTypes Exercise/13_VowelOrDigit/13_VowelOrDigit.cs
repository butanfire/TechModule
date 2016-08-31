namespace _13_VowelOrDigit
{
    using System;
    using System.Collections.Generic;

    public class VowelOrDigit
    {
        public static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine().ToLowerInvariant());

            List<char> vowels = new List<char>(new[] { 'a', 'e', 'o', 'i', 'u', 'y' });
            int number = 0;
            bool isNumber = int.TryParse(input.ToString(), out number);
            if (vowels.Contains(input))
            {
                Console.WriteLine("vowel");
            }
            else if (isNumber)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
