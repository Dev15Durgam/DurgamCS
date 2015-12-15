using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Radio radio;

            for (int i = 0; i < 10; i++)
            {
                radio = new Radio() { Volume = random.Next(0, 100), Frequency = random.Next(875, 1080) / 10d };

                Console.WriteLine(radio.ToString());

                Console.ReadLine();
            }
        }
    }
}
