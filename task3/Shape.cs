using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
        public abstract class Shape
        {
            public abstract double CalculateArea();
            public abstract double CalculatePerimeter();

            public virtual void Display()
            {
                Console.WriteLine($"Shape: {this.GetType().Name}, Area: {CalculateArea():N2}, Perimeter: {CalculatePerimeter():N2}");
            //GetType()  =>وظيفتها إرجاع نوع الكائن الحقيقي وقت التشغيل (Run-time type).
        }
    }
    }

