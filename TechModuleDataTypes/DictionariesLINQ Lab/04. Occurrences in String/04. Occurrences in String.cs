namespace _04.Occurrences_in_String
{
    using System;

    public class OccurrencesInString
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLowerInvariant();
            var word = Console.ReadLine().ToLowerInvariant();

            int occurrences = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text.IndexOf(word, i) != -1)
                {
                    occurrences++;
                    i = text.IndexOf(word, i);
                }
            }

            Console.WriteLine(occurrences);
        }
    }
}
