namespace _04.Extract_Sentences_by_Keyword
{
    using System;
    using System.Linq;

    public class ExtractSenteces
    {
        static void Main(string[] args)
        {
            var sentenceSeperators = new[] { '.', '!', '?' };
            var wordExtracted = Console.ReadLine();
            var text = Console.ReadLine().Split(sentenceSeperators).ToArray();
            bool keywordFound = false;

            foreach (var sentence in text)
            {
                var line = sentence.Split(' ').ToList();

                foreach (string words in line)
                {
                    var word = words;
                    for (int letter = 0; letter < word.Length; letter++)
                    {
                        if (!char.IsLetterOrDigit(word[letter]))
                        {
                            word = word.Replace(word[letter], ' ');
                            var seperatedWord = word.Split(' ');
                            if (seperatedWord.Contains(wordExtracted))
                            {
                                keywordFound = true;
                            }
                        }
                    }
                }

                if (keywordFound || line.Any(word => word == wordExtracted))
                {
                    Console.WriteLine(string.Join(" ", line));
                }

                keywordFound = false;
            }
        }
    }
}

