using System;

namespace _3_Practice_Characters_and_Strings
{
    public class CharactersStrings
    {
        public static void Main(string[] args)
        {
            String input = Console.ReadLine();
            char letter1 = Char.Parse(Console.ReadLine());
            char letter2 = Char.Parse(Console.ReadLine());
            char letter3 = Char.Parse(Console.ReadLine());
            String input2 = Console.ReadLine();
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}",input,letter1,letter2,letter3,input2);
        }
    }
}
