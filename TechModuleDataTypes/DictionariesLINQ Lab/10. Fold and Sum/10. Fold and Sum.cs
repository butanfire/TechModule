namespace _10.Fold_and_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FoldAndSum
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            int k = input.Length / 4;

            var firstRowsStart = input.Take(k).Select(int.Parse).Reverse().ToList();
            var firstRowsEnd = input.Reverse().Take(k).Select(int.Parse).ToList();

            List<int> firstRows = new List<int>(firstRowsStart);
            firstRows.AddRange(firstRowsEnd);

            var secondRow = input.Skip(k).Take(2 * k).Select(int.Parse).ToList();

            var folderSum = firstRows.Select((element, index) => element + secondRow[index]);

            Console.WriteLine(string.Join(" ", folderSum));
        }
    }
}
