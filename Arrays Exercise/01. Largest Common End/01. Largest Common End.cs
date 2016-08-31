namespace _01.Largest_Common_End
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargestCommonEnd
    {
        public static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();

            int minLen = Math.Min(firstArray.Length, secondArray.Length);
            int sequenceStart = -1;
            int Leftlength = 0;
            for (int i = 0; i < minLen; i++) 
            {
                if (firstArray[i] == secondArray[i])
                {
                    if (sequenceStart == -1)
                    {
                        sequenceStart = i;
                        Leftlength++;
                    }

                    if (sequenceStart != i)
                    {
                        Leftlength++;
                    }
                }
            }

            sequenceStart = -1;
            int Rightlength = 0;

            List<string> first = firstArray.ToList();
            List<string> second = secondArray.ToList();

            while(minLen > 0) { 
                if (first.Last() == second.Last())
                {
                    if (sequenceStart == -1)
                    {
                        sequenceStart = minLen;
                        Rightlength++;
                    }

                    if (sequenceStart != minLen)
                    {
                        Rightlength++;
                    }
                }

                minLen--;
                first.RemoveAt(first.Count -1);
                second.RemoveAt(second.Count - 1);
            }

            Console.WriteLine(Rightlength > Leftlength ? Rightlength : Leftlength);
        }
    }
}
