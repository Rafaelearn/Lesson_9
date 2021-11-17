using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            ACiper aCiper = new ACiper();
            BCiper bCiper = new BCiper();
            Console.WriteLine("Task 1| Test");
            Console.Write("string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Coding A");
            aCiper.Encode(ref str);
            Console.WriteLine("Encode: " + str);
            aCiper.Decode(ref str);
            Console.WriteLine("Decode: " + str);
            Console.WriteLine("Coding B");
            bCiper.Encode(ref str);
            Console.WriteLine("Encode: " + str);
            bCiper.Decode(ref str);
            Console.WriteLine("Decode: " + str);

            Console.WriteLine("Task 2| Test");
            Circle circle = new Circle(1, 2, 2);
            Point point = new Point(4, 5);
            Rectangle rectangle = new Rectangle(1, 2, 7, 8);
            Console.WriteLine($"Площадь прямоугольника: {rectangle.GetSquare()}");
            Console.WriteLine($"Площадь круга: {circle.GetSquare()}");
            point.MoveHorz(12);
            circle.Colour = Colour.Brown;
            circle.Condition = false;
            rectangle.Colour = Colour.Yellow;
            rectangle.MoveVert(-10);
            Console.WriteLine("Point: ");
            point.Display();
            Console.WriteLine("Circle: ");
            circle.Display();
            Console.WriteLine("Rectangle ACBD");
            rectangle.Display();

        }
    }
}
