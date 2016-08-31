namespace _2_Practice_Floating_Points
{
    using System;

    public class FloatingPoints
    {
        static void Main(string[] args)
        {
            decimal inputDouble = decimal.Parse(Console.ReadLine());
            double inputFloat = double.Parse(Console.ReadLine());
            decimal inputDecimal = decimal.Parse(Console.ReadLine());

            Console.WriteLine("{0}\n{1}\n{2}\n", inputDouble, inputFloat, inputDecimal);
        }
    }
}
