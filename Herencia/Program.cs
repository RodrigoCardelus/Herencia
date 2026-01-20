using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo auto = new Auto("Puertas 4", "ruedas 4", "1.6");

            Vehiculo vehiculo = new Vehiculo("ruedas 3", "1.8");

            //Console.WriteLine(vehiculo.ToString());

            Console.WriteLine(auto.ToString());

            Console.ReadKey();
            

        }
    }
}
