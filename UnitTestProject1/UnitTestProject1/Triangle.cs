using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    public class Triangle
    {
        private readonly double[] _sides;
        private readonly Dictionary<Func<bool>, string> _typeConditions;

        public Triangle(double side1, double side2, double side3)
        {
            _sides = new[] { side1, side2, side3 }.OrderBy(x => x).ToArray();
            _typeConditions = new Dictionary<Func<bool>, string>
            {
                {IsRightTriangle, "Right triangle"},
                {IsObtuseTriangle, "Obtuse triangle"},
                {IsAcuteTriangle, "Acute triangle"},
            };
        }

        public IEnumerable<string> GetTriangleType()
        {
            foreach (var typeCondition in _typeConditions)
            {
                if (typeCondition.Key())
                {
                    yield return typeCondition.Value;
                }
            }
        }

        private static double square(double number)
        {
            return Math.Pow(number, 2);
        }

        private bool IsAcuteTriangle()
        {
            return square(_sides[0]) + square(_sides[1]) > square(_sides[2]);
        }

        private bool IsObtuseTriangle()
        {
            return square(_sides[0]) + square(_sides[1]) < square(_sides[2]);
        }

        private bool IsRightTriangle()
        {
            return square(_sides[0]) + square(_sides[1]) == square(_sides[2]);
        }
    }
}