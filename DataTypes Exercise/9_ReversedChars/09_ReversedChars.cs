namespace _9_ReversedChars
{
    using System;

    public class ReversedChars
    {
        public static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{2}",letter3,letter2,letter1);
        }
    }
}
