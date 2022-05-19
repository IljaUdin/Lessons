using System;
using Lesson_8_2_;
using Xunit;

namespace Test_Lesson_8_2_
{
    public class Test_8_2
    {
        [Theory]
        [InlineData(1, 4.1887902047863905)]
        [InlineData(1, 4)]
        public void CalculaterBall(int radius, double expectedResult)
        {
            Ball ball = new Ball(radius);
            var result = ball.Volume();

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(-1, -1)]
        [InlineData(2, 8)]
        public void CalculaterBox(int height, double expectedResult)
        {
            Box box = new Box(height);
            var result = box.Volume();

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CalculaterCylinder()
        {
            Cylinder cylinder = new Cylinder(1, 1);
            var result = cylinder.Volume();

            Assert.Equal(Math.PI, result);
        }

        [Fact]
        public void CalculaterPyramid()
        {
            Pyramid pyramid = new Pyramid(3, 1);
            var result = pyramid.Volume();

            Assert.Equal(1, result);
        }
    }
}
