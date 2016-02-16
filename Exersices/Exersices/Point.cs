using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice3
{

    public class Point
    {

        private int y;
        private int x;

        public void SetX(int x)
        {
            this.x = x;
        }

        public int GetX()
        {
            return this.x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public int GetY()
        {
            return this.y;
        }

        public Point3D ConvertToPoint3D(Point p)
        {
            return (Point3D) p;
        }
    }

    public class Point3D:Point
        {
            public int test(int x)
            {
                return x;
            }
        }

}
  