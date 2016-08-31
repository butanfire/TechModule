using System;
using System.Linq;

namespace _01.Max_Sequence_of_Equal_Elements
{
    public class MaxSeqOfEqualElements
    {
        static void Main(string[] args)
        {
            var inputNums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            int currLen = 1;
            int currPos = 0;

            int maxLen = 1;
            int maxPos = 0;

            for (int i = 0; i < inputNums.Count - 1; i++)
            {
                var currentNumber = inputNums[i];
                var nextNumber = inputNums[i + 1];
                if (currentNumber == nextNumber) //check whether the sequence continues
                {
                    currLen++;
                    currPos = i;
                }
                else
                {
                    currLen = 1;
                }

                if (currLen > maxLen)
                {
                    maxLen = currLen;
                    maxPos = currPos;
                }
            }

            if (maxPos == 0 && maxLen == 1) //cases where there is only 1 number
            {
                maxPos = -1;
            }

            for (int i = maxPos + 1; maxLen > 0; maxLen--, i--)
            {
                Console.Write("{0} ", inputNums[i]);
            }

        }
    }
}
