using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_2_
{
    public class Pyramid : Shape
    {
        double _height, _square;
        public Pyramid(int height, int square)
        {
            _height = height;
            _square = square;
        }
        public override string NameFigure()
        {
            return "Пирамида";
        }
        public override double Volume()
        {
            return (_square * _height / 3);
        }
    }
}
