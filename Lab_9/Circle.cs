using System;

namespace Lab_9
{
    class Circle : Point
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (radius < 0)
                {
                    throw new FormatException("radius of circle < 0");
                }
                radius = value;
            }
        }
        public Circle(double xCenter, double yCenter, double radius) : base(xCenter, yCenter)
        {
            Radius = radius;
        }
        public override void Display()
        {
            Console.WriteLine($"Radius = {radius}");
            base.Display();
        }
        public double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
