using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static implicit operator Point3D(Point point)
        {
            return new Point3D(point.X, point.Y, 0);
        }
        public override string ToString() => $"X: {X} Y: {Y}";
    }
}
