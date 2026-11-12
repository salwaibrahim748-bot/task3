using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    public class ColoredRectangle : ColoredShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public ColoredRectangle(string color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea() => Width * Height;
        public override double CalculatePerimeter() => 2 * (Width + Height);

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Color: {Color}");
        }
    }
}
