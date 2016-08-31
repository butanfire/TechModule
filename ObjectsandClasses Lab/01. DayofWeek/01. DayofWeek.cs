using System;

namespace _01.DayofWeek
{
    public class DayOfWeek
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('-');
            DateTime output = new DateTime(int.Parse(input[2]),int.Parse(input[1]),int.Parse(input[0])); //parsing the DateTime as string.
            Console.WriteLine(output.DayOfWeek);
        }
    }
}
