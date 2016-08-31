namespace _6_TriplesOfLetters
{
    using System;

    public class TriplesOfLetters
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                char first = (char)('a' + i);
                for (int j = 0; j < input; j++)
                {
                    char second = (char)('a' + j);
                    for (int s = 0; s < input; s++)
                    {
                        char third = (char)('a' + s);
                        Console.WriteLine("{0}{1}{2}", first, second, third);
                    }
                }
            }
        }
    }
}
