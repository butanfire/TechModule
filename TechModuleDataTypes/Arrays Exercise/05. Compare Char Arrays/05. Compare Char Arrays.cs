namespace _05.Compare_Char_Arrays
{
    using System;
    using System.Collections.Generic;

    public class CompareCharArrays
    {
        public static void Main(string[] args)
        {
            String[] word1 = Console.ReadLine().Split(' ');
            String[] word2 = Console.ReadLine().Split(' ');

            string outputWord1 = String.Empty;
            string outputWord2 = String.Empty;

            for (int i = 0; i < word1.Length; i++)
            {
                outputWord1 += word1[i];
            }

            for (int i = 0; i < word2.Length; i++)
            {
                outputWord2 += word2[i];
            }

            List<string> output = new List<string>();
            output.Add(outputWord1);
            output.Add(outputWord2);

            output.Sort();

            Console.WriteLine(output[0]);
            Console.WriteLine(output[1]);
        }
    }
}
