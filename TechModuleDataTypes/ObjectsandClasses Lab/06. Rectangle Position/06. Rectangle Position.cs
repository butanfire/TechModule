using System;
using System.Linq;

namespace _07.Rectangle_Position
{
    public class RectanglePosition
    {
        static void Main(string[] args)
        {
            var rect1 = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray(); //rectangle coordinates
            var rect2 = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            Rectangle r1 = new Rectangle(rect1[0], rect1[1], rect1[2], rect1[3]); //create the rectangles
            Rectangle r2 = new Rectangle(rect2[0], rect2[1], rect2[2], rect2[3]);

            bool isInside = Rectangle.IsRectInside(r1, r2);

            Console.WriteLine(isInside ? "Inside" : "Not inside");
        }
    }

    internal class Rectangle
    {
        public Rectangle(decimal left, decimal top, decimal width, decimal height)
        {
            this.Left = left;
            this.Top = top;
            this.Width = width;
            this.Height = height;
        }

        public decimal Top { get; set; }

        public decimal Left { get; set; }

        public decimal Width { get; set; }

        public decimal Height { get; set; }

        public decimal Right => this.Height + this.Top;

        public decimal Bottom => this.Width + this.Left;

        public static bool IsRectInside(Rectangle r, Rectangle r1)
        {
            return r.Left >= r1.Left && r.Right <= r1.Right && r.Top >= r1.Top && r.Bottom <= r1.Bottom;
        }
    }

}
