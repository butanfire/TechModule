using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ').ToArray();
            decimal output = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReverseString(numbers[i]);
                output += decimal.Parse(numbers[i]);
            }
            
            Console.WriteLine(output);
        }

        private static string ReverseString(string s)
        {
            StringBuilder temp = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                temp.Append(s[i]);
            }

            return temp.ToString();
        }
    }
}
