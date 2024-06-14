using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Vendedor : Empleado
    {
        public Vendedor(string calle, int altura, string localidad, string distrito, string codPostal, string provincia, string pais, string nombre, string apellido, int dni, string email, int telefono, int numLegajo, string nombreUsuario, string clave, string perfil, int indicadorPerfil) : base(calle, altura, localidad, distrito, codPostal, provincia, pais, nombre, apellido, dni, email, telefono, numLegajo, nombreUsuario, clave, perfil, indicadorPerfil)
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
