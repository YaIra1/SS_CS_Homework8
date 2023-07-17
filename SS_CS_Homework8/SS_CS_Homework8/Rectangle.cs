namespace SS_CS_Homework8
{
    public class Rectangle : Point2D
    {
        private double _width;
        private double _height;

        public double Width { get { return _width; } }
        public double Height { get { return _height; } }

        public Rectangle(double x, double y, double width, double height) : base(x, y)
        {
            _width = width;
            _height = height;
        }

        public override void Resize(double percent)
        {
            _width *= percent;
            _height *= percent;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override double Perimeter()
        {
            return Width * 2 + Height * 2;
        }

        public override string ToString()
        {
            return $"Rectangle: left upper corner:{{{X}, {Y}}}, width {Width}, height {Height}, area {Area()}, perimetr {Perimeter()}";
        }
    }
}
