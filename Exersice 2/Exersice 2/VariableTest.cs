using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice_2
{
    class VariableTest
    {
        //int jagÄrEttFält;//tillgänglig i hela klassen för all metoder
        static void Main(string[] args)
        {
            PrindStockIndex();  
            PiCalculater();
            JonasAdress();
            //int jagÄrEnVariabel;// jag finns bara i denna main metoden, sen dör jag tyvärr. intierat variabel
            //jagÄrEnVariabel = 7;
        }

        private static void PrindStockIndex()
        {
            double dowJones = -4.6;
            Console.WriteLine("Dow Jones index: {0}", dowJones);
            Console.WriteLine("Dow Jones index: " + dowJones);
            Console.WriteLine(@"Dow Jones index: {0}", dowJones);
            Console.WriteLine($"Dow Jones index: {dowJones}");

            double nasdaq = -4.1;
            Console.WriteLine("Nasdaq index: {0}", nasdaq);
            Console.WriteLine("Nasdaq index: " + nasdaq);
            Console.WriteLine(@"Nasdaq index: {0}", nasdaq);
            Console.WriteLine($"Nasdaq index: {nasdaq}");

            double stockholm = -2.4;
            Console.WriteLine("Stockholm index: {0}", stockholm);
            Console.WriteLine("Stockholm index: " + stockholm);
            Console.WriteLine(@"Stockholm index: {0}", stockholm);
            Console.WriteLine($"Stockholm index: {stockholm}");

            double milano = -6.7;
            Console.WriteLine("Milano index: {0}", milano);
            Console.WriteLine("Milano index: " + milano);
            Console.WriteLine(@"Milano index: {0}", milano);
            Console.WriteLine($"Milano index: {milano}");

            double paris = -5.5;
            Console.WriteLine("Paris index: {0}", paris);
            Console.WriteLine("Paris index: " + paris);
            Console.WriteLine(@"Paris index: {0}", paris);
            Console.WriteLine($"Paris index: {paris}");
        }

        static void PiCalculater()
        {
            const double exactPiValue = 3.141592654;
            //exactPiValue = ++;
            Console.WriteLine("The exact PI value {0}:", exactPiValue);
            Console.WriteLine("The exact PI value:" + exactPiValue);
            Console.WriteLine(@"The exact PI value {0}:", exactPiValue);
            Console.WriteLine($"The exact PI value: {exactPiValue}");

            double roundedPiValue = 3.14;
            Console.WriteLine("The rounded PI value {0}: ", roundedPiValue);
            Console.WriteLine("The rounded PI value:" + roundedPiValue);
            Console.WriteLine(@"The rounded PI value {0}:", roundedPiValue);
            Console.WriteLine($"The rounded PI value: {roundedPiValue}");

            double hardRoundedPi = 3;
            Console.WriteLine("Hard rounded PI value {0}: ", hardRoundedPi);
            Console.WriteLine("Hard rounded PI value:" + hardRoundedPi);
            Console.WriteLine(@"Hard rounded PI value {0}:", hardRoundedPi);
            Console.WriteLine($"Hard rounded PI value: {roundedPiValue}");


        }
        static void JonasAdress()
        {
            string name = "Jonas";
            string city = "Helsingborg";
            string adress = "Statten vid Hemköp";

            Console.WriteLine("Freddie har en vän som heter {0}. Han bor i {2} som då ligger {1}", name, city, adress);
            Console.ReadLine();
        }
    }
}
