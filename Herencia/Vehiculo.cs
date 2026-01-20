using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    public class Vehiculo
    {
        private string ruedas;
        private string motor;

        public Vehiculo(string _ruedas, string _motor)
        {
            ruedas = _ruedas;
            motor = _motor;
        }

        public virtual void Transportar()
        {
            Console.WriteLine("Voy de A a B...");
        }

        public string Ruedas
        {
            get
            {
                return ruedas;
            }
            set
            {
                ruedas = value;
            }
        }


        public string Motor
        {
            get
            {
                return motor;
            }
            set
            {
                motor = value;
            }
        }

        public override string ToString()
        {
            return motor + " " + ruedas;
        }

    }
}
