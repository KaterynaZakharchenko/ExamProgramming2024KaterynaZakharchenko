using System;

namespace Geometry
{
    public class Point : IReflectable
    {
        private double x;
        private double y;
        public double X = x;
        private double Y = y;

        public Point(double c1, double c2)
        {
            this.x = c1;
            this.y = c2;
        }

        public Point(double c) : this.(c, 0) {
        }

        public void ReflectX()
        {
            this.x = (0 - this.x);
        }
        public void ReflectY()
        {
            this.y = (0 - this.y);
        }
    }

    enum PointColour
    {
        Red, Green, Blue
    }

    public class ColourfulPoint : Point
    {
        public PointColour Colour;

        public ColourfulPoint(PointColour col) : base(x, y)
        {
            this.Colour = col;
        }
    }
}
