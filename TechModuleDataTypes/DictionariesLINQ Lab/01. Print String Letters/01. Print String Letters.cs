namespace _01.Print_String_Letters
{
    using System;

    public class PrintStringLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("str[{0}] -> '{1}'", i, input[i]);
            }
        }
    }
}
