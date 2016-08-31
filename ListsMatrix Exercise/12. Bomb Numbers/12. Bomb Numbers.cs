using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Bomb_Numbers
{
    public class BombNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var bombNum = bomb[0];
            var bombRange = bomb[1];

            List<int> bombIndexes = new List<int>();
            List<int> adjacentIndexes = new List<int>();

            int findIndex = 0;
            while (findIndex >= 0)
            {
                findIndex = Array.FindIndex(numbers, findIndex, s => s == bombNum);
                if (findIndex != -1)
                {
                    bombIndexes.Add(findIndex);
                    findIndex++;
                }
            }

            for (int i = 1; i <= bombRange; i++)
            {
                for (int j = 0; j < bombIndexes.Count; j++)
                {
                    if (bombIndexes.Count > 1)
                        if (numbers[bombIndexes[j]] == numbers[bombIndexes[j] + 1])
                        {
                            continue;
                        }
                    if (bombIndexes[j] + i >= 0 && bombIndexes[j] + i < numbers.Length)
                    {
                        adjacentIndexes.Add(bombIndexes[j] + i);
                    }
                    if (bombIndexes[j] - i >= 0 && bombIndexes[j] - i < numbers.Length)
                    {
                        adjacentIndexes.Add(bombIndexes[j] - i);
                    }
                }
            }

            decimal sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!bombIndexes.Contains(i) && !adjacentIndexes.Contains(i))
                {
                    sum += numbers[i];
                }

            }

            Console.WriteLine(sum);
        }
    }
}
