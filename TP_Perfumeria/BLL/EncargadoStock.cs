using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class EncargadoStock : Empleado
    {
        //Constructor (lo hace el visual cuando le indicas la dependencia)
        public EncargadoStock(int numLegajo, string nombreUsuario, string clave, string perfil) : base(numLegajo, nombreUsuario, clave, perfil)
        {
        }

        public void altaProducto() {
        }

        public void buscarProducto() { 
        }

        public void listarProductos() { 
        }

        public void modificarProductos()
        {
        }



    }
}
