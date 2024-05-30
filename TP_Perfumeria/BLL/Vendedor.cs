using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Vendedor : Empleado
    {
        public Vendedor(int numLegajo, string nombreUsuario, string clave, string perfil) : base(numLegajo, nombreUsuario, clave, perfil)
        {
        }

        public void buscarCliente() {
        }

        public void buscarProducto() { 
        }

        public void modificarCliente() { 
        }

        public void realizarVenta()
        {

        }
    }
}
