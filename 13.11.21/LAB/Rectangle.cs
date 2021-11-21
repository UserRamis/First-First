namespace LAB
{
    class Rectangle : Point
    {
        public double Width;
        public double High;

        public Rectangle(double width, double high)
        {
            Width = width;
            High = high;
        }

        public override double GetSquare()
        {
            return Width * High;
        }
    }
}