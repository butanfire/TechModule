namespace _04.Last_K_Numbers_Sums_Sequence
{
    using System;

    public class LastKnumbersSumsSeq
    {
       public static void Main(string[] args)
        {
            long numberOfElements = long.Parse(Console.ReadLine());
            long endSeq = long.Parse(Console.ReadLine());

            long[] sequence = new long[numberOfElements];
            sequence[0] = 1;
            
            for (int i = 1; i < numberOfElements; i++)
            {
                int j = i;
                long lastKelements = endSeq;
                while (j >= 1)
                {
                    sequence[i] += sequence[j-1];
                    j--;
                    lastKelements--;
                    if (lastKelements == 0)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ",sequence));
        }
    }
}
