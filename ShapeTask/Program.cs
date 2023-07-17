namespace ShapeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Circle("Circle1", 3),
                new Square("Square1", 200),
                new Circle("Circle2", 43),
                new Square("Square2", 0.456),
                new Circle("Circle3", 3.23)
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }
            Console.WriteLine();

            Shape maxPerimeterShape = shapes.Max(new ShapePerimeterComparer());
            Console.WriteLine($"The shape with the max perimeter is: {maxPerimeterShape.Name} has perimeter {maxPerimeterShape.Perimeter()}");
            Console.WriteLine();

            shapes.Sort();
            Console.WriteLine("Sorted shapes by area");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }
            Console.WriteLine();
        }
    }
}