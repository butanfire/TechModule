using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Sales_Report
{
    public class SalesReport
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Sale> sales = new List<Sale>();

            for (int i = 0; i < lines; i++)
            {
                string[] arguments = Console.ReadLine().Split(' ').ToArray();
                sales.Add(new Sale(
                    arguments[0], //town
                    arguments[1],  //product
                    double.Parse(arguments[2]), //price
                    double.Parse(arguments[3]))); //quantity
            }

            var towns = sales.Select(s => s.Town).Distinct().OrderBy(s => s).ToList();
            foreach (var town in towns)
            {
                var salesPerTown = sales.Where(s => s.Town == town).ToList();
                double sum = salesPerTown.Sum(sale => sale.Quantity * sale.Price);
                Console.WriteLine("{0} -> {1:F2}", town, sum);
            }
        }
    }

    internal class Sale
    {
        public string Town { get; set; }

        public string Product { get; set; }

        public double Price { get; set; }

        public double Quantity { get; set; }

        public Sale(string town, string product, double price, double quantity)
        {
            this.Town = town;
            this.Product = product;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
