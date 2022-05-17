using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_2_
{
    class Ball : Shape
    {
        double _radius;

        public Ball(int radius)
        {
            _radius = radius;
        }
        public override string NameFigure()
        {
            return "Мяч";
        }
        public override double Volume()
        {
            return (4 * Math.PI * Math.Pow(_radius, 3) / 3);
        }
    }
}
