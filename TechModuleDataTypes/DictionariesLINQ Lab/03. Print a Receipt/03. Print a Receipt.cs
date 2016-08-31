namespace _03.Print_a_Receipt
{
    using System;
    using System.Linq;

    public class PrintReceipt
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            string topRow = new string('-', 22);
            Console.WriteLine("/{0}\\", topRow);

            foreach (var num in input)
            {
                Console.WriteLine("| {0,20:f2} |", num);
            }

            Console.WriteLine("|{0}|", topRow);
            Console.WriteLine("| Total:{0,14:f2} |", input.Sum());
            Console.WriteLine("\\{0}/", topRow);
        }
    }
}
