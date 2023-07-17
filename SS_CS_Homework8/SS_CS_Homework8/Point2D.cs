namespace SS_CS_Homework8
{
    public class Point2D
    {
        private double _x;
        private double _y;

        public double X { get { return _x; } }
        public double Y { get { return _y; } }

        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public virtual void Move(double dx, double dy)
        {
            _x += dx;
            _y += dy;
        }

        public virtual void Resize(double percent)
        {

        }

        public virtual double Area()
        {
            return 0;
        }

        public virtual double Perimeter()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"Point: {{{X}, {Y}}}";
        }
    }
}
