using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    public class Camion : Vehiculo
    {
        public Camion(string _puertas, string _ruedas, string _motor)
            : base(_ruedas, _motor)
        {
            puertas = _puertas;
        }

        private string puertas;

        public string Puertas
        {
            get
            {
                return puertas;
            }
            set
            {
                puertas = value;
            }
        }
    }
}
