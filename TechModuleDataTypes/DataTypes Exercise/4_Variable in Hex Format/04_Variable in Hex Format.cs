namespace _4_Variable_in_Hex_Format
{
    using System;

    public class HexFormat
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            input = input.Substring(2, input.Length - 2);
            Console.WriteLine(Convert.ToInt32(input,16));
        }
    }
}
