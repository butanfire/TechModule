using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Array_Manipulator
{
    public class ArrayManipulator
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "print")
            {
                string[] arguments = command.Split(' ').ToArray();
                switch (arguments[0])
                {
                    case "add":
                        Add(ref input, int.Parse(arguments[1]), int.Parse(arguments[2]));
                        break;
                    case "contains":
                        Contains(input, int.Parse(arguments[1]));
                        break;
                    case "addMany":
                        int[] numbers = new int[arguments.Length - 2];
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] = int.Parse(arguments[i + 2]);
                        }

                        AddMany(ref input, numbers, int.Parse(arguments[1]));
                        break;
                    case "remove":
                        Remove(ref input, int.Parse(arguments[1]));
                        break;
                    case "shift":
                        Shift(ref input, int.Parse(arguments[1]));
                        break;
                    case "sumPairs":
                        SumPairs(ref input);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", input));
        }

        public static void Add(ref List<int> input, int index, int element)
        {
            input.Insert(index, element);
        }

        public static void Contains(List<int> input, int element)
        {
            Console.WriteLine(input.IndexOf(element));
        }

        public static void AddMany(ref List<int> input, int[] numbers, int index)
        {
            input.InsertRange(index, numbers);
        }

        public static void Remove(ref List<int> input, int index)
        {
            input.RemoveAt(index);
        }

        private static void SumPairs(ref List<int> input)
        {
            int len = input.Count / 2;
            for (int i = 0; i < len; i++)
            {
                input[i + 1] += input[i];
                input.RemoveAt(i);
            }
        }

        private static void Shift(ref List<int> input, int shiftIndex)
        {
            int[] numsArr = new int[input.Count];
            for (int currentPosition = 0; currentPosition < shiftIndex; currentPosition++)
            {
                int firstElement = input[0];
                for (int i = 0; i < input.Count - 1; i++)
                {
                    numsArr[i] = input[i + 1];
                }

                numsArr[numsArr.Length - 1] = firstElement;
                input = new List<int>(numsArr);
            }
        }
    }
}
