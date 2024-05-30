using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Producto
    {
        private int _cantidadMinima;

        public int CantidadMinima
        {
            get { return _cantidadMinima; }
            set { _cantidadMinima = value; }
        }

        private string _categoria;

        public string Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private float _precio;

        public float Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        private int _stock;

        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public void configurarAlerta() {
        
        }

       

    }
}
