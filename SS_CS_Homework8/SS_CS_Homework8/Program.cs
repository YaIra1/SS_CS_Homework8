using System;

namespace SS_CS_Homework8
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Point2D> shapes = new List<Point2D>()
            {
                new Point2D(2, 3),
                new Circle(4, 6, 2),
                new CircleInSquare(4, 7, 9),
                new Rectangle(3, 6, 8, 7.8),
                new Romb(5, 6, 9, 11)

            };

            foreach (Point2D shape in shapes)
            {
                Console.WriteLine(shape);
            }
            Console.WriteLine();

            foreach (Point2D shape in shapes)
            {
                shape.Resize(1.1);

                Console.WriteLine(shape);
            }
        }
    }
}