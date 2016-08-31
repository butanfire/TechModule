namespace _10_Filled_Square
{
    using System;
    using System.Text;

    public class FilledSquare
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string topRow = new String('-',2 * input);
            Console.WriteLine(topRow);

            StringBuilder output = new StringBuilder();
            
            for (int i = 0; i < input - 1; i++)
            {
                output.Append(@"\");
                output.Append(@"/");
            }

            for (int i = 0; i < input - 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", "-", output.ToString());
            }

            Console.WriteLine(topRow);
        }
    }
}
