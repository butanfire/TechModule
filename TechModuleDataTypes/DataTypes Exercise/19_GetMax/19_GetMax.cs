namespace _19_GetMax
{
    using System;

    public class GetMax
    {
        public static void Main(string[] args)
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());
            int numberC = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(numberC, GetMax(numberA, numberB)));
        }

        public static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }
    }
}
