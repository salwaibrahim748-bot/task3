using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    public class Triangle : Shape
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double baseLength, double height, double sideA, double sideB, double sideC)
        {
            BaseLength = baseLength;
            Height = height;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double CalculateArea() => 0.5 * BaseLength * Height;
        public override double CalculatePerimeter() => SideA + SideB + SideC;
    }
}
