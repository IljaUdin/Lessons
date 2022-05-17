using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    class Polygon
    {
        Point[] _points;

        public Polygon(params Point[] points)
        {
            _points = points;
        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X,2) + Math.Pow(a.Y - b.Y, 2));
        }
        public double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 1; i < _points.Length; i++)
            {
                perimeter += LengthSide(_points[i - 1], _points[i]);
            }
            perimeter += LengthSide(_points[0], _points[_points.Length - 1]);
            return perimeter;
        }
    }
}
