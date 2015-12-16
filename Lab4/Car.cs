using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Car
    {
        //string mark, color, type;
        //int totalGear;
        private string mark;
        private string color;
        private string type;
        private int totalGear;

        public string Mark
        {

            get { return mark; }
            set {
                if (value != null)
                    mark = value;
                else
                    throw new Exception("invalid input");
                }
        }
        public string Color
        {
            get { return color; }
            set {if(value!=null)
                    color = value;
                }
        }
        public string Type
        {
            get { return type; }
            set {if (value != null && value == "coupe" || value == "kombi")
                    type = value;
                else
                    throw new Exception("invalid input , Type kombi or coupe Only");
                }
        }
        public int TotalGear
        {
            get { return totalGear; }
            set { totalGear = value; }
        }
        public Car(string mark,string color,string type, int totalGear)
        {
            Mark = mark;
            Color = color;
            Type = type;
            TotalGear = totalGear;
        }
        public override string ToString()
        {
            return $"mark of the Car{Mark} color:{Color} type :{Type} gear{TotalGear}";   
        }




    }
}
