using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice4
{
    class Radio
    {
        private static int _instanceCount;
        public static int InstanceCount
        {
            get
            {
                return _instanceCount;
            }
            private set
            {
                _instanceCount = value;
            }
        }

        private double _frequency;
        private int _volume;

        public bool IsOn { get; set; }
        public int Volume
        {
            get
            {
                return this._volume;
            }
            set
            {
                if (value >= 0 && value < 100)
                    this._volume = value;
            }
        }
        public double Frequency
        {
            get
            {
                return this._frequency > 87.5 && this._frequency < 108 ? this._frequency : -1;
            }
            set
            {
                if (value > 87.5 && value < 108)
                    this._frequency = value;
            }
        }

        static Radio()
        {
            Radio.InstanceCount = 0;
        }

        public Radio()
        {
            Radio.InstanceCount++;

            //this.IsOn = false;

            this.Volume = 10;
            this.Frequency = 87.5;
        }
        public Radio(int volume) : this()
        {
            this.Volume = volume;
        }

        public Radio(int volume, double frequency) : this(volume)
        {
            this.Frequency = frequency;
        }

        public override string ToString() => string.Format("{3}: The power is {0}, frequency is set to {1} and volume is {2}", IsOn ? "On" : "Off", Frequency, Volume, InstanceCount);
    }
}
