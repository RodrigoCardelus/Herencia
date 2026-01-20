using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    public class Moto : Vehiculo
    {
        public Moto(bool _tieneSideCar, string _ruedas, string _motor)
            : base(_ruedas, _motor)
        {
            tieneSideCar = _tieneSideCar;
        }


        private bool tieneSideCar;


        public bool TieneSideCar
        {
            get
            {
                return tieneSideCar;
            }
            set
            {
                tieneSideCar = value;
            }
        }
    }
}
