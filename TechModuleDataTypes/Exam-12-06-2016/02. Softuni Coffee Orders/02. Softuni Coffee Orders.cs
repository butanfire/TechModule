namespace SoftUniCofeeOrders
{
    using System;
    using System.Globalization;

    public class SoftUniCofeeOrders
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            for (int i = 0; i < lines; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", new CultureInfo("en-US"));
                long capsuleCount = long.Parse(Console.ReadLine());

                decimal orderPrice = DateTime.DaysInMonth(orderDate.Year, orderDate.Month) * capsuleCount * pricePerCapsule;
                Console.WriteLine("The price for the coffee is: ${0:F2}", orderPrice);
                totalPrice += orderPrice;
            }

            Console.WriteLine("Total: ${0:F2}", totalPrice);
        }
    }
}
