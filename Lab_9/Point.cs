using System;

namespace Lab_9
{
    class Point : Figure
    {
        protected Dot PointA;
        public Point(double x, double y)
        {
            PointA.x = x;
            PointA.y = y;
        }
        public override void Display()
        {
            Console.WriteLine($"x = {PointA.x}");
            Console.WriteLine($"y = {PointA.y}");
            Console.Write($"Condition: ");
            if (Condition)
            {
                Console.WriteLine("visible");
            }
            else
            {
                Console.WriteLine("invisible");
            }
            Console.WriteLine($"Colour: {Colour}");
        }
        public override void MoveHorz(double delta)
        {
            PointA.x += delta;
        }
        public override void MoveVert(double delta)
        {
            PointA.y += delta;
        }
    }
}
