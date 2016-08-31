namespace _07.Max_Sequence_of_Increasing_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxSequenceIncreasing
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> longestInputSeq = new List<int>();
            List<List<int>> longestInputDB = new List<List<int>>();

            for (int i = 1; i < input.Length; i++)
            {
                int current = i - 1; //start from 0
                if (input[current] == input[i]) //if the sequence is increasing, add the number
                {
                    longestInputSeq.Add(input[current]);
                }
                else
                {
                    longestInputSeq.Add(input[current]); //when the current number is the last of the subsequence, add it
                    longestInputDB.Add(new List<int>(longestInputSeq.GetRange(0, longestInputSeq.Count))); //add the sequence list to the db
                    longestInputSeq.Clear(); //clear the iterator list
                }
            }
            if (longestInputSeq.Count >= 0) //add the last number from the sequence.
            {
                longestInputSeq.Add(input[input.Length - 1]);
            }

            longestInputDB.Add(new List<int>(longestInputSeq.GetRange(0, longestInputSeq.Count))); //add the last iterator list

            List<int> longestSeqInDb = new List<int>(longestInputDB[0]); //list for the longest sub sequence fetched from the db

            for (int i = 1; i < longestInputDB.Count; i++)
            {
                if (longestSeqInDb.Count < longestInputDB[i].Count) //if the number of elements from the candidate list is smaller than the next subsequence count
                {
                    longestSeqInDb.Clear(); //clear the candidate list
                    longestSeqInDb.AddRange(longestInputDB[i]); //fill the candidate list with the larger subsequence
                }
            }

            Console.WriteLine(string.Join(" ", longestSeqInDb)); //output the largest subsequence
        }
    }
}
