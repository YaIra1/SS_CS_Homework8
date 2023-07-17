namespace SS_CS_Homework8
{
    public class CircleInSquare : Circle
    {
        public double Side { get { return Radius * 2; } }

        public CircleInSquare(double x, double y, double radius) : base(x, y, radius)
        {
        }

        public override double Area()
        {
            var circleArea = base.Area();
            return Side * Side - circleArea;
        }

        public override double Perimeter()
        {
            var circlePerimeter = base.Perimeter();
            return Side * 4 + circlePerimeter;
        }

        public override string ToString()
        {
            return $"Circle in square: center:{{{X}, {Y}}}, radius {Radius}, side {Side}, area {Area()}, perimetr {Perimeter()}";
        }
    }
}
