namespace _11.Common_Strings
{
    using System;
    using System.Linq;

    public class CommonStrings
    {
        static void Main(string[] args)
        {
            var wordA = Console.ReadLine();
            var wordB = Console.ReadLine();

            bool common = wordA.Any(letterA => wordB.Any(letterB => letterA == letterB));

            string answer = common ? "yes" : "no";
            Console.WriteLine(answer);
        }
    }
}
