using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void when_side_3_4_5_should_be_Right_triangle()
        {
            var triangle = new Triangle(3, 4, 5);
            var type = triangle.GetTriangleType();
            Assert.AreEqual("Right triangle", type);
        }
    }

    public class Triangle
    {
        private readonly int _side1;
        private readonly int _side2;
        private readonly int _side3;

        public Triangle(int side1, int side2, int side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public string GetTriangleType()
        {
            return "";
        }
    }
}