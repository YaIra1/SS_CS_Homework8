namespace ShapeTask
{
    public class ShapePerimeterComparer : IComparer<Shape>
    {
        public int Compare(Shape? x, Shape? y)
        {
            var xPerimeter = x.Perimeter();
            var yPerimeter = y.Perimeter();
            if (xPerimeter < yPerimeter) return -1;
            if (xPerimeter == yPerimeter) return 0;
            return 1;
        }
    }
}
