using System;
using System.Linq;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void when_side_3_4_5_should_be_right_triangle()
        {
            var triangle = new Triangle(3.0, 4.0, 5.0);
            var type = triangle.GetTriangleType();
            Assert.AreEqual("Right triangle", type);
        }

        [Test]
        public void when_side_10_12_15_should_be_acute_triangle()
        {
            var triangle = new Triangle(10, 12, 15);
            var type = triangle.GetTriangleType();
            Assert.AreEqual("Acute triangle", type);
        }

        [Test]
        public void when_side_6_7_12_should_be_obtuse_triangle()
        {
            var triangle = new Triangle(6, 7, 10);
            var type = triangle.GetTriangleType();
            Assert.AreEqual("Obtuse triangle", type);
        }
    }

    public class Triangle
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;

        public Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public string GetTriangleType()
        {
            var sides = new[] { _side1, _side2, _side3 }.OrderBy(x => x).ToArray();

            if (IsRightTriangle(sides))
            {
                return "Right triangle";
            }
            else if (IsAcuteTriangle(sides))

            {
                return "Acute triangle";
            }
            else
            {
                return "Obtuse triangle";
            }
        }

        private static bool IsAcuteTriangle(double[] sides)
        {
            return square(sides[0]) + square(sides[1]) > square(sides[2]);
        }

        private static bool IsRightTriangle(double[] sides)
        {
            return square(sides[0]) + square(sides[1]) == square(sides[2]);
        }

        private static double square(double number)
        {
            return Math.Pow(number, 2);
        }
    }
}