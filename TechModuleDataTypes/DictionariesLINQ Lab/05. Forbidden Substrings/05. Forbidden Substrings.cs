namespace _05.Forbidden_Substrings
{
    using System;
    using System.Linq;

    public class ForbiddenSubstrings
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(' ').ToArray();
            var words = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < text.Length; i++)
            {
                foreach (var word in words)
                {
                    text[i] = text[i].Replace(word, new string('*',word.Length));
                }
            }

            Console.WriteLine(string.Join(" ",text));
        }
    }
}
