using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class AdministradoSistema : Empleado
    {
        public AdministradoSistema(int numLegajo, string nombreUsuario, string clave, string perfil) : base(numLegajo, nombreUsuario, clave, perfil)
        {
        }
        public void altaEmpleado()
        {
        } //No se porque me tira error

        public void bajaEmpleado()
        {
        }

        public void buscarEmpleado()
        {
        }

        public void modificarEmpleado()
        {
        }
    }
}
