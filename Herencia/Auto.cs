using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    public class Auto : Vehiculo
    {
        private string puertas;

        public Auto(string _puertas, string _ruedas, string _motor) : base(_ruedas, _motor)
        {
            puertas = _puertas;
        }

        public override string ToString()
        {
            return base.ToString() + " " +puertas + " " + Ruedas + " " + Motor;
        }

        public override void Transportar()
        {
            
        }


        //public override void Transportar()
        //{
        //    base.Transportar();
        //    Console.WriteLine("Llegué");
        //}

    }

}
