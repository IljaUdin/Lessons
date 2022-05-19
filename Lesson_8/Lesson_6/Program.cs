using System;
using System.Collections.Generic;

namespace Lesson_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Polygon polygon = new Polygon(new Point("A", 1, 1), new Point("B", 2,1), new Point("C", 0, 1));

            Console.WriteLine("Периметр многоугольника равен : {0:0.000}", polygon.CalculatePerimeter());

            Console.ReadKey();
        }
    }
}
