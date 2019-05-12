using System.Collections.Generic;
using System.Linq;
using ExpectedObjects;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(3, 4, 5)]
        [TestCase(8, 15, 17)]
        [TestCase(20, 21, 29)]
        public void when_two_side_square_sum_equal_one_side_should_be_right_triangle(double side1, double side2, double side3)
        {
            var triangle = new Triangle(side1, side2, side3);
            var type = triangle.GetTriangleType();
            var expect = new List<string>() { "Right triangle" };
            Assert.AreEqual(expect, type);
        }

        [TestCase(10, 12, 15)]
        public void when_two_side_square_sum_more_then_one_side_should_be_acute_triangle(int side1, int side2, int side3)
        {
            var triangle = new Triangle(side1, side2, side3);
            var type = triangle.GetTriangleType();
            var expect = new List<string>() { "Acute triangle" };

            Assert.AreEqual(expect, type);
        }

        [TestCase(6, 7, 12)]
        [TestCase(15, 10, 21)]
        public void when_two_side_square_sum_less_then_one_side_should_be_obtuse_triangle(int side1, int side2, int side3)
        {
            var triangle = new Triangle(side1, side2, side3);
            var type = triangle.GetTriangleType();
            var expect = new List<string>() { "Obtuse triangle" };

            Assert.AreEqual(expect, type);
        }

        [Test]
        public void when_three_side_are_same_should_be_equilateral_triangle()
        {
            var triangle = new Triangle(3, 3, 3);
            var type = triangle.GetTriangleType();
            var expect = new List<string>() { "Equilateral triangle", "Acute triangle" }.ToExpectedObject();
            expect.ShouldEqual(type.ToList());
        }

        [Test]
        public void when_two_side_sum_less_then_one_side_should_be_not_triangle()
        {
            var triangle = new Triangle(100, 3, 3);
            var type = triangle.GetTriangleType();
            var expect = new List<string>() { "Not triangle" }.ToExpectedObject();
            expect.ShouldEqual(type.ToList());
        }

        [Test]
        public void when_two_side_are_same_should_be_isosceles_triangle()
        {
            var triangle = new Triangle(6, 6, 3);
            var type = triangle.GetTriangleType();
            var expect = new List<string>() { "Isosceles triangle", "Acute triangle" }.ToExpectedObject();
            expect.ShouldEqual(type.ToList());
        }
    }
}