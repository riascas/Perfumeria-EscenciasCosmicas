using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Item : Venta
    {
        private int _cantidad;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        private int _subtotal;

        public int Subtotal
        {
            get { return _subtotal; }
            set { _subtotal = value; }
        }


    }
}
