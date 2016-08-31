namespace Problem_2.Array_Modifier
{
    using System;
    using System.Linq;

    public class ArrayModifier
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            var commands = Console.ReadLine().Split(' ').ToArray();

            while (commands[0] != "end")
            {
                int index1;
                int index2;
                switch (commands[0])
                {
                    case "swap":
                        index1 = int.Parse(commands[1]);
                        index2 = int.Parse(commands[2]);
                        var temp = numbers[index1];
                        numbers[index1] = numbers[index2];
                        numbers[index2] = temp;
                        break;
                    case "multiply":
                        index1 = int.Parse(commands[1]);
                        index2 = int.Parse(commands[2]);
                        numbers[index1] *= numbers[index2];
                        break;
                    case "decrease":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] -= 1;
                        }
                        break;
                }

                commands = Console.ReadLine().Split(' ').ToArray();
            }

            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}
