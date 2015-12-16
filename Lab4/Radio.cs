using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Radio
    {
        public int volume;
        public bool turn;
        public double tuning;
        public static int instanceCount=0;
        public int Volume
        {
            get { return volume; }
            set {
                if (value >= 1 && value <= 10)
                    volume = value;
                else
                    throw new Exception("invalid input , Please enter volume from 1 to 10");
                }
        }
        public bool TurnOn
        {
            get { return turn; }
            set {if (value == true)
                    turn = value;
                else
                    throw new Exception("please turn the radio on");
                }
        }
        public double Tuning
        {
            get { return tuning; }
            set {if (value >= 87.5 && value <= 108.0)
                    tuning = value;
                else
                    throw new Exception("invalid input , tuning range (87.5-108.0)");
                }
        }
        public Radio(int volume,double tuning,string onoff)
        {
            instanceCount++;

            Volume = volume;
            Tuning = tuning;
            if (onoff == "yes")
                this.TurnOn = true;
            else
                this.TurnOn = false;
        }

        public Radio() { }

        public Radio(string onoff)
        {
            if (onoff == "yes")
                this.TurnOn = true;
            else
                this.TurnOn = false;

        }
        public override string ToString()
        {
            return $"the Radio is On you have selected volume {Volume} and tuning {Tuning} megahertz (MHz), total count of radios created :  {instanceCount}";
        }
    }
    
}
