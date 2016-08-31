namespace Circle_Area
{
    using System;

    public class CircleArea
    {
        public static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F12}", Math.Pow(radius, 2) * Math.PI);
        }
    }
}
