namespace SS_CS_Homework8
{
    public class Circle : Point2D
    {
        private double _radius;

        public double Radius { get { return _radius; } }

        public Circle(double x, double y, double radius) : base(x, y)
        {
            _radius = radius;
        }

        public override void Resize(double percent)
        {
            _radius *= percent;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override double Perimeter()
        {
            return Math.PI * 2 * Radius;
        }

        public override string ToString()
        {
            return $"Circle: center:{{{X}, {Y}}}, radius {Radius}, area {Area()}, perimetr {Perimeter()}";
        }
    }
}
