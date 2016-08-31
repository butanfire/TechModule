namespace Problem_1.Sweet_Dessert
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var cash = decimal.Parse(Console.ReadLine());
            var guests = int.Parse(Console.ReadLine());
            var bananaPrice = double.Parse(Console.ReadLine());
            var eggPrice = double.Parse(Console.ReadLine());
            var berryPrice = double.Parse(Console.ReadLine());

            //for a set of 6 - 2 banana, 4 egg , 0.2 berries
            decimal neededExpense = 0m;
            var expense = 2d * bananaPrice + 4d * eggPrice + berryPrice * 0.2d;
            if (guests % 6 > 0)
            {
                neededExpense = (decimal)((guests / 6 + 1) * expense);
            }
            else
            {
                neededExpense = (decimal)(guests / 6 * expense);
            }


            if (cash >= neededExpense)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", neededExpense);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", Math.Abs(cash - neededExpense));
            }
        }
    }
}
