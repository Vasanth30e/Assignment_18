using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone("Samsung S23");
            Laptop laptop = new Laptop("Hp Victus");


            smartphone.Connect();
            smartphone.Charge(100);

            laptop.Connect();
            laptop.Charge(200);

            Console.WriteLine(smartphone.Display());
            Console.WriteLine(laptop.Display());

            Console.ReadKey();
        }
    }
}
