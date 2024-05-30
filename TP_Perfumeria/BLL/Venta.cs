using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Venta
    {
        private DateTime _fechaVenta;

        public DateTime FechaVenta
        {
            get { return _fechaVenta; }
            set { _fechaVenta = value; }
        }

        private int _numVenta;

        public int NumVenta
        {
            get { return _numVenta; }
            set { _numVenta = value; }
        }

        private float _subtotal;

        public float Subtotal
        {
            get { return _subtotal; }
            set { _subtotal = value; }
        }

        public void descontarStock() { 
        }

        public void generarFactura() { 
        }


    }
}
