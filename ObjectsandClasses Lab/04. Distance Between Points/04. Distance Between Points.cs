using System;
using System.Linq;

namespace _04.Distance_Between_Points
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point pointA = new Point(input[0], input[1]);

            input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point pointB = new Point(input[0], input[1]);
            
            Console.WriteLine(Point.CalcDistance(pointA, pointB));
        }
    }

    internal class Point
    {
        public Point(int x, int y)
        {
            this.PointX = x;
            this.PointY = y;
        }

        public int PointX { get; set; }

        public int PointY { get; set; }

        public static double CalcDistance(Point a, Point b)
        {
            double x = a.PointX - b.PointX;
            double y = a.PointY - b.PointY;

            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
    }
}
