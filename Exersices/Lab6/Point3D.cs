using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z = 0)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }


        public static implicit operator Point(Point3D point3D)
        {
            return new Point(point3D.X, point3D.Y);
        }
        public override string ToString() => $"X: {X} Y: {Y}  Z: {Z}";

    }
}
