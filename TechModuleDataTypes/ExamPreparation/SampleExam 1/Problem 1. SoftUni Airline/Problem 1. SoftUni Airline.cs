namespace Problem_1.SoftUni_Airline
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniAirline
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            List<decimal> output = new List<decimal>();
            for (int i = 0; i < lines; i++)
            {
                long adultPassengersCount = long.Parse(Console.ReadLine());
                decimal adultTicketPrice = decimal.Parse(Console.ReadLine());
                long youthPassengersCount = long.Parse(Console.ReadLine());
                decimal youthTicketPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPrice = decimal.Parse(Console.ReadLine());
                decimal fuelConsumption = decimal.Parse(Console.ReadLine());
                short flightDuration = short.Parse(Console.ReadLine());

                decimal expenses = flightDuration*fuelConsumption*fuelPrice;
                var income = adultPassengersCount*adultTicketPrice + youthPassengersCount*youthTicketPrice;

                var profit = income - expenses;
                output.Add(profit);

                Console.WriteLine(
                    income >= expenses
                        ? "You are ahead with {0:F3}$."
                        : "We've got to sell more tickets! We've lost {0:F3}$.", profit);
            }

            Console.WriteLine("Overall profit -> {0:F3}$.",output.Sum());
            Console.WriteLine("Average profit -> {0:F3}$.", output.Average());
        }
    }
}
