using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Closest_Two_Points
{
    public class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>();
            for (int i = 0; i < lines; i++)
            {
                var arguments = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                points.Add(new Point(arguments[0], arguments[1]));
            }

            int pointAindex = 0;
            int pointBindex = 0;
            var minDistance = double.MaxValue;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var result = Point.DistancePoints(points[i], points[j]); //get the distance between the points
                    if (minDistance > result) //if the distance is less than the current
                    {
                        minDistance = result; //we keep it
                        pointAindex = i; //we keep the index of the point A
                        pointBindex = j; //and the index of the point B
                    }
                }
            }

            Console.WriteLine("{0:F3}", minDistance);
            Point.Print(points[pointAindex]);
            Point.Print(points[pointBindex]);
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

        public static double DistancePoints(Point a, Point b)
        {
            double x = a.PointX - b.PointX;
            double y = a.PointY - b.PointY;

            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        public static void Print(Point a)
        {
            Console.WriteLine("({0}, {1})", a.PointX, a.PointY);
        }
    }
}
