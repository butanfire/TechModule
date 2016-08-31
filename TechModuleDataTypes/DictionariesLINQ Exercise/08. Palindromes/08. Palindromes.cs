namespace _08.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Palindromes
    {
        static void Main(string[] args)
        {
            var seperators = new[] { '.', ',', ' ', '!', '?' };
            var input = Console.ReadLine().Split(seperators, StringSplitOptions.RemoveEmptyEntries).ToList();
            var palindromes = new List<string>();

            foreach (var word in input)
            {
                bool isPalindrome = true;
                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (word[i] != word[word.Length - i - 1]) //check the first half of the string and the second half, if they are not equal it is not a palindrome
                    {
                        isPalindrome = false;
                    }
                }

                if (isPalindrome)
                {
                    palindromes.Add(word);
                }
            }

            palindromes.Sort();

            Console.WriteLine(string.Join(", ", palindromes.Distinct()));
        }
    }
}
