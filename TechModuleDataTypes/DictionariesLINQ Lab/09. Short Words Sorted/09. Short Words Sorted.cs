namespace _09.Short_Words_Sorted
{
    using System;
    using System.Linq;

    public class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            var seperators = new char[] {'.',';',',',':','(',')','[',']','\'','/','!','?',' '};
            var input = Console.ReadLine().ToLowerInvariant().Split(seperators,StringSplitOptions.RemoveEmptyEntries).ToArray();

            var output = input.OrderBy(x => x).Where(s => s.Length < 5).Distinct().ToList();

            Console.WriteLine(string.Join(", ",output));
        }
    }
}
