using System;
using System.Linq;

namespace _03.Intersection_of_Circles
{
    public class IntersetctionOfCircles
    {
        static void Main(string[] args)
        {
            var pointAargs = Console.ReadLine().Split(' ').ToArray();
            var pointBargs = Console.ReadLine().Split(' ').ToArray();

            Circle a = new Circle(new Point(int.Parse(pointAargs[0]), int.Parse(pointAargs[1])), int.Parse(pointAargs[2]));
            Circle b = new Circle(new Point(int.Parse(pointBargs[0]), int.Parse(pointBargs[1])), int.Parse(pointBargs[2]));

            Console.WriteLine(Circle.IntersectCircles(a, b) ? "Yes" : "No");
        }
    }

    internal class Circle
    {
        public Point Center { get; set; }

        public int Radius { get; set; }

        public Circle(Point center, int radius)
        {
            this.Center = center;
            this.Radius = radius;
        }

        public static bool IntersectCircles(Circle a, Circle b)
        {
            return a.Radius + b.Radius >= Point.PointDistance(a.Center, b.Center);
        }

    }

    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static double PointDistance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
    }
}

