using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_2_
{
    public class Cylinder : Shape
    {
        double _height, _radius;
        public Cylinder (double height, double radius)
        {
            _height = height;
            _radius = radius;
        }
        public override string NameFigure()
        {
            return "Цилиндр";
        }
        public override double Volume()
        {
            return (Math.PI*Math.Pow(_radius, 2)*_height);
        }
    }
}
