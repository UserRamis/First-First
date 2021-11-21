using System;
using System.Drawing;


namespace LAB
{
    struct Location
    {
        public double X;
        public double Y;
    }
    enum MovingType
    {
        Horizontally,
        Vertically
    }
    class Figure : IFigureActions
    {
        private Location location;
        private Color color;
        private bool visible;

        public Location Location { get => location; }
        public Color Color { get => color; }
        public bool Visible { get => visible; }

        public void Move(MovingType movingType, double value)
        {
            if (movingType == 0)
            {
                location.X += value;
            }
            else
            {
                location.Y += value;
            }
        }

        public void SetColor(Color color)
        {
            this.color = color;
        }

        public void ChangeVisible()
        {
            visible = !visible;
        }
    }
}