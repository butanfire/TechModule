namespace _09.Capitalization
{
    using System;
    using System.Linq;

    public class Capitalization
    {
        static void Main(string[] args)
        {
            var seperators = new[] { '.', ',', ' ', '!', '?', ';' };
            var input = Console.ReadLine().Split(seperators, StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                string letter = input[i][0].ToString().ToUpperInvariant();
                input[i] = letter + input[i].Substring(1, input[i].Length - 1);
            }

            Console.WriteLine(string.Join(" ",input));
        }
    }
}
