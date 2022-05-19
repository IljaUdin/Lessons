using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_1
{
    public class Point
    {
        public int X {get;}
        public int Y {get;}
        public string NamePoint { get;}
        public Point(string namepoint, int x, int y)
        {
            NamePoint = namepoint;
            X = x;
            Y = y;
        }
    }
}
