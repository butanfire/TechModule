using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Split_by_Word_Casing
{
    public class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            var delimiters = new char[] {'.','!','"',' ',',',';','\'',':','/','\\','(', ')','[',']'};
            var input = Console.ReadLine().Split(delimiters).ToList();
            input.RemoveAll(s => s == "");

            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();
            bool mixed = false;
            bool upper = false;
            bool lower = false;

            foreach (string word in input)
            {
                foreach (var character in word)
                {
                    if (char.IsSymbol(character) || char.IsDigit(character) || !char.IsLetterOrDigit(character))
                    {
                        mixed = true;
                        break;
                    }

                    if (char.IsUpper(character))
                    {
                        upper = true;
                    }

                    if (char.IsLower(character))
                    {
                        lower = true;
                    }
                }
                
                if (upper && lower || mixed)
                {
                    mixedCase.Add(word);
                }

                else if (upper)
                {
                    upperCase.Add(word);
                }

                else if (lower)
                {
                    lowerCase.Add(word);
                }

                upper = false;
                lower = false;
                mixed = false;
            }

            Console.WriteLine("Lower-case: {0}\nMixed-case: {1}\nUpper-case : {2}",
                string.Join(", ", lowerCase), string.Join(", ", mixedCase), string.Join(", ", upperCase));
        }
    }
}
