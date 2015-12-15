using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice3
{
    class Program
    {

        static void Main(string[] args)
        {
            Exersice3Call();
            Uppgift4Call();
        }

        private static void Exersice3Call()
        {
            Person person = new Person();
            Person person2 = new Person();
            Person person3 = new Person();

            person.SetName("Durgam");
            person2.SetName("Durgam II");
            person3.SetName("Durgam III");

            Console.WriteLine(person.GetName());
            Console.WriteLine(person2.GetName());
            Console.WriteLine(person3.GetName());


            Circle circle = new Circle();

            circle.SetDiameter("10");

            Console.WriteLine(circle.GetCircumference());


            Point point = new Point();

            point.SetX(10);

            Console.WriteLine(point.GetX());

            point.SetY(20);

            Console.WriteLine(point.GetY());

            circle.SetCenter(point);

        }

        private static void Uppgift4Call()
        {
            Adress adress = new Adress()
            {
                city = "HBG",
                street = "Storagatan",
                zip = 55555
            };

            PersonInfo durgam = new PersonInfo()
            {
                Name = "Durgam",
                Age = 24,
                Adress = adress
            };
            PersonInfo durgam2 = new PersonInfo()
            {
                Name = "Durgam2",
                Age = 24,
                Adress = new Adress()
                {
                    city = "HBG",
                    street = "Storagatan",
                    zip = 55555
                }
            };

            Console.WriteLine($"{ durgam.Name} Är {durgam.Age} år gammal och bor på {adress.street} {adress.zip} {adress.city}.");
            Console.ReadLine();
        }
    }
}
