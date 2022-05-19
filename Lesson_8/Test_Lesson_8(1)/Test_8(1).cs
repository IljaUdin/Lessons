using System;
using Lesson_8_1;
using Xunit;

namespace Test_Lesson_8_1_
{
    public class Test_8_1
    {
        [Fact]
        public static void LengthSideTest()
        {
            Point a = new Point("A", 1, 1);
            Point b = new Point("B", 2, 1);
            Point c = new Point("C", 0, 1);
            Polygon polygon = new Polygon(a, b, c);

            var resultlength = polygon.LengthSide(a, b);

            Assert.Equal(1, resultlength);
        }

        [Fact]
        public static void PerimeterTest()
        {
            Point a = new Point("A", 1, 1);
            Point b = new Point("B", 2, 1);
            Point c = new Point("C", 0, 1);
            Polygon polygon = new Polygon(a, b, c);

            var resultperimeter = polygon.CalculatePerimeter();

            Assert.Equal(4, resultperimeter);
        }
    }
}
