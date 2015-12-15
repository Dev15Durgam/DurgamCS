using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice3
{
    public class Circle
    {
        private double diameter;
        private Point point;

        public void SetDiameter(string diameter)
        {
            if(diameter != null)
            //koll mot null och om inte siffra!!!
            //tryparse
            this.diameter = double.Parse(diameter); //gör med tryparse. läs på nätet
        }
        public double GetDiameter()
        {
            return this.diameter;
        }
        public double GetCircumference()
        {
            return (this.diameter * 3.1416);
        }

        public void SetCenter(Point point)
        {
            this.point = point;
        }
     
        public Point GetCenter()
        {
            return this.point;
        }
    }
}
