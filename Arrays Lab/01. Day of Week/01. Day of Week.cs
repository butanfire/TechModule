namespace _01.Day_of_Week
{
    using System;

    public class DayOfWeek
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string[] daysOfWeek = new[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (input - 1 < 0 || input > 7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(daysOfWeek[input - 1]);
            }
        }
    }
}
