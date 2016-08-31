using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Count_Working_Days
{
    public class CountWorkingDays
    {
        static void Main(string[] args)
        {
            var startDate = Console.ReadLine().Split('-');
            var endDate = Console.ReadLine().Split('-');
            
            var start = new DateTime(int.Parse(startDate[2]), int.Parse(startDate[1]), int.Parse(startDate[0])); //parsing via String, DateTime.ParseExact can also be used
            var end = new DateTime(int.Parse(endDate[2]), int.Parse(endDate[1]), int.Parse(endDate[0]));
            
            var officialHolidays = new List<DateTime>() //adding the official holidays manually, for the respective year of the input (startDate)
            {
                new DateTime(int.Parse(startDate[2]),01,01),
                new DateTime(int.Parse(startDate[2]),03,03),
                new DateTime(int.Parse(startDate[2]),05,01),
                new DateTime(int.Parse(startDate[2]),05,06),
                new DateTime(int.Parse(startDate[2]),05,24),
                new DateTime(int.Parse(startDate[2]),09,06),
                new DateTime(int.Parse(startDate[2]),09,22),
                new DateTime(int.Parse(startDate[2]),11,01),
                new DateTime(int.Parse(startDate[2]),12,24),
                new DateTime(int.Parse(startDate[2]),12,25),
                new DateTime(int.Parse(startDate[2]),12,26)
            };

            int workCounter = 0;

            
            for (var i = start; i <= end; i = i.AddDays(1))
            {
                
                if (officialHolidays.Any(m => m.Day == i.Day && m.Month == i.Month) || 
                    i.DayOfWeek == DayOfWeek.Sunday ||
                    i.DayOfWeek == DayOfWeek.Saturday) continue;
                workCounter++;
            }

            Console.WriteLine(workCounter);
        }
    }
}
