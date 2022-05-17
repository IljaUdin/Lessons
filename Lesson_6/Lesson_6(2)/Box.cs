using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_2_
{
    class Box : Shape
    {
        double _height, _volume;
        List<Shape> shapes = new List<Shape>();
        public Box (double height)
        {
            _height = height;
        }
        public double VolumeCube
        {
            get { return _volume; }
        }
        public override string NameFigure()
        {
            return "Коробка";
        }
        public override double Volume()
        {
            _volume = Math.Pow(_height, 3);
            return _volume;
        }
        public bool Add(Shape shape)
        {
            if (_volume > shape.Volume())
            {
                shapes.Add(shape);
                Console.WriteLine("Добавьте следующую фигуру");
                _volume -= shape.Volume();
                return true;
            }
            else
            {
                Console.WriteLine("Объем фигуры {0} превышает остаточный объем", shape.NameFigure());
                return false;
            }     
        }
        public void Figure_in_Box()
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine("{0} с объемом : {1:0.00}", shapes[i].NameFigure(), shapes[i].Volume());
            }
        }
    }
}
