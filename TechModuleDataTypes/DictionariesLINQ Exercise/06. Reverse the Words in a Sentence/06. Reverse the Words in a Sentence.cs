namespace _06.Reverse_the_Words_in_a_Sentence
{
    using System;
    using System.Linq;

    public class ReverseWordsInSentence
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            char[] split = {'.',',',':',';','=','(',')','&','[',']','\"','\'','\\','/','!','?'};
            var words = input.Split(split,StringSplitOptions.RemoveEmptyEntries).ToList();

            //cases where - word.word occurs, the split does not split them correctly, so adding a space between each word, splitting and removing the empty string does the job.
            string wholeText = words.Aggregate(string.Empty, (current, t) => current + t + " ");
            words = wholeText.Split(' ').ToList();
            words.RemoveAll(s => s == ""); //remove empty entries

            char[] appender = new char[1000]; //get all chars so we can split/extract the seperators from the text.
            int index = 0;
            foreach (var letter in words.SelectMany(word => word)) //collect all the words, in order to collect the seperators
            {
                appender[index++] = letter; 
            }
            
            var separators = input.Split(appender).ToList();
            separators.RemoveAll(s => s == ""); //remove empty entries
            words.Reverse();

            var len = Math.Min(separators.Count, words.Count);

            for (int i = 0; i < len; i++)
            {
                Console.Write("{0}{1}",words[i], separators[i]);
            }
        }
    }
}
