namespace _10.Extract_Middle_1__2_or_3_Elements
{
    using System;
    using System.Linq;

    public class ExtractElements
    {
        public static void Main()
        {
            var readLine = Console.ReadLine();
            if (readLine != null)
            {
                int[] numbers = readLine.Split(' ').Select(int.Parse).ToArray();

                int len = numbers.Length;

                int middle1 = (len / 2) - 1;
                int middle2 = len / 2;
                int middle3 = (len / 2) + 1;

                if (len < 2)
                {
                    Console.WriteLine(numbers.First());
                }
                else if (len % 2 == 0)
                {
                    Console.WriteLine("{0} {1}", numbers[middle1], numbers[middle2]);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", numbers[middle1], numbers[middle2], numbers[middle3]);
                }
            }
        }
    }
}
