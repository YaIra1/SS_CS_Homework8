namespace SS_CS_Homework8
{
    public class Romb : Point2D
    {
        private double _diagonalH;
        private double _diagonalV;

        public double DiagonalH { get { return _diagonalH; } }
        public double DiagonalV { get { return _diagonalV; } }

        public Romb(double x, double y, double diagonalH, double diagonalV) : base(x, y)
        {
            _diagonalH = diagonalH;
            _diagonalV = diagonalV;
        }

        public override void Resize(double percent)
        {
            _diagonalH *= percent;
            _diagonalV *= percent;
        }

        public override double Area()
        {
            return DiagonalH * DiagonalV / 2.0;
        }

        public override double Perimeter()
        {
            return 2 * Math.Sqrt(DiagonalH * DiagonalH + DiagonalV * DiagonalV);
        }

        public override string ToString()
        {
            return $"Romb: center:{{{X}, {Y}}}, horizontal diagonal {DiagonalH}, vertical diagonal {DiagonalV}, area {Area()}, perimetr {Perimeter()}";
        }
    }
}
