using System;

namespace Lab_9
{
    class Rectangle : Point
    {
        protected Dot PointB;
        public Rectangle(double xPointA, double yPointA, double xPointB, double yPointB) : base(xPointA, yPointA)
        {
            PointB.x = xPointB;
            PointB.y = yPointB;
        }
        public override void Display()
        {
            Console.WriteLine("Point D:");
            Console.WriteLine($"x = {PointB.x}");
            Console.WriteLine($"y = {PointA.y}");
            Console.WriteLine("Point C:");
            Console.WriteLine($"x = {PointA.x}");
            Console.WriteLine($"y = {PointB.y}");
            Console.WriteLine("Point B:");
            Console.WriteLine($"x = {PointB.x}");
            Console.WriteLine($"y = {PointB.y}");
            Console.WriteLine("Point A:");
            base.Display();
        }
        public override void MoveHorz(double delta)
        {
            PointA.x += delta;
            PointB.x += delta;
        }
        public override void MoveVert(double delta)
        {
            PointA.y += delta;
            PointB.y += delta;
        }
        public double GetSquare()
        {
            return Math.Abs((PointA.x - PointB.x) * (PointA.y - PointB.y));
        }
    }
}
