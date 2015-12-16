using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Car toyota = new Car("toyota","red","kombi",4);
            //    Console.WriteLine(toyota);
            //Car toyota = new Car("toyota", "red", "coupe", 4);
            //Console.WriteLine(toyota);

            
            //radio.TurnOn = false;
            Console.WriteLine("Turn on the radio?");
            string value = Console.ReadLine();
            Radio radio = new Radio(8, 88.0,value);
            Console.WriteLine(radio);



            Console.WriteLine("Turn on the radio?");
             value = Console.ReadLine();
            Radio radio2 = new Radio(8, 88.0, value);
            Console.WriteLine(radio2);

            Console.WriteLine("Turn on the radio?");
            value = Console.ReadLine();
            Radio radio3 = new Radio(value) { volume = 10, tuning = 89.2 };

       
            //if (value == "yes")
            //    radio.TurnOn = true;
            //else
            //    radio.TurnOn = false;

            //Console.WriteLine(radio.TurnOn.ToString());
        }
    }
}
