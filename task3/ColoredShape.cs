using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
        public abstract class ColoredShape : Shape
        {
            public string Color { get; set; }

            protected ColoredShape(string color)
            {
                Color = color;
            }
        }

    }


