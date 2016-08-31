namespace _02.Fit_String_in_20_Chars
{
    using System;
    using System.Linq;

    public class FitString
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input.Length < 20)
            {
                input += "*";
            }

            Console.WriteLine(string.Join("",input.Take(20)));
        }
    }
}
