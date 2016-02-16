using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"*****************Uppgift 1*****************
");

            Uppgift1();
            
            Console.WriteLine(@"
*****************Uppgift 3*****************
");
            Uppgift3();

            Console.WriteLine(@"
*****************Uppgift 4*****************
");
            Uppgift4();

            Console.ReadLine();
        }

        private static void Uppgift1()
        {
            float floatlab = float.MaxValue;
            Console.WriteLine("Float type: " + floatlab);

            long longLab = long.MaxValue;
            Console.WriteLine("Long type: " + longLab);

            char grade = 'A';
            Console.WriteLine("Char type: " + grade);

            string stringlab = "Long sentnces";
            Console.WriteLine("String type: " + stringlab);

            ulong unsignedLong = ulong.MaxValue;
            Console.WriteLine("UnsignedLong type:" + unsignedLong);
        }

       private static void Uppgift3()
        {
            Point point = new Point(3, 4);
            Console.WriteLine(point);
            Point3D point3D = new Point(3, 2);
            Console.WriteLine(point3D);
        }

        private static void Uppgift4()
        {
            MyDoubleType mdt1 = new MyDoubleType(5);
            MyDoubleType mdt2 = mdt1 + 5;
            MyDoubleType mdt3 = mdt1 + mdt2;
            MyDoubleType mdt4 = new MyDoubleType(5);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}",
                 mdt1, mdt2, mdt3, mdt1 > mdt2, mdt1 == mdt4);
        }
    }
}
