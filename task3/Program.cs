namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
                new Circle(5),
                new Rectangle(4, 6),
                new Triangle(3, 4, 3, 4, 5),
                new Circle(3),
                new ColoredRectangle("Red", 5, 5)
            };

            double totalArea = 0;
            Shape largestShape = shapes[0];

            Console.WriteLine("--- Shapes Details ---");
            foreach (var shape in shapes)
            {
                shape.Display();
                double area = shape.CalculateArea();
                totalArea += area;

                if (area > largestShape.CalculateArea())
                {
                    largestShape = shape;
                }
            }

            Console.WriteLine($"Total Area of all shapes: {totalArea:N2}"); //N2 لعرض رقمين عشريين
            Console.WriteLine($"Shape with the largest area: {largestShape.GetType().Name} with Area: {largestShape.CalculateArea():N2}");
        }
    }
}
