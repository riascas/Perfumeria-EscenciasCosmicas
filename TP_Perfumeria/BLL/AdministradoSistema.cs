using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AdministradorSistema : Empleado
    {


        public AdministradorSistema(string calle, int altura, string localidad, string distrito, string codPostal, string provincia, string pais, string nombre, string apellido, int dni, string email, int telefono, int numLegajo, string nombreUsuario, string clave, string perfil, int indicadorPerfil) : base(calle, altura, localidad, distrito, codPostal, provincia, pais, nombre, apellido, dni, email, telefono, numLegajo, nombreUsuario, clave, perfil, indicadorPerfil)
        {
            this.Calle = calle;
            this.Altura = altura;
            this.Localidad = localidad;
            this.Distrito = distrito;
            this.CodPostal = codPostal;
            this.Provincia = provincia;
            this.Pais = pais;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
            this.Email = email;
            this.Telefono = telefono;
            this.NumLegajo = numLegajo;
            this.NombreUsuario = nombreUsuario;
            this.Clave = clave;
            this.Perfil = perfil;
            this.IndicadorPerfil = indicadorPerfil;
        }
        
        public void altaEmpleado(string calle, int altura, string localidad, string distrito, string codPostal, string provincia, string pais, string nombre, string apellido, int dni, string email, int telefono, int numLegajo, string nombreUsuario, string clave, string perfil, int indicadorPerfil)
        {
            
            SqlParameter[] parametros = new SqlParameter[17];
            Conexion ObjConexion = new Conexion();
            ObjConexion.EscribirPorStoreProcedure("AltaNuevoEmpleado", parametros);
            
             parametros[0] = ObjConexion.crearParametro("@Calle", calle);
             parametros[1] = ObjConexion.crearParametro("@Altura", altura);
             parametros[2] = ObjConexion.crearParametro("@Localidad", localidad);
             parametros[3] = ObjConexion.crearParametro("@Distrito", distrito);
             parametros[4] = ObjConexion.crearParametro("@Cod_Postal", codPostal);
             parametros[5] = ObjConexion.crearParametro("@Provincia", provincia);
             parametros[6] = ObjConexion.crearParametro("@Pais", pais);
             parametros[7] = ObjConexion.crearParametro("@Nombre", nombre);
             parametros[8] = ObjConexion.crearParametro("@Apellido", apellido);
             parametros[9] = ObjConexion.crearParametro("@DNI", dni);
             parametros[10] = ObjConexion.crearParametro("@Email", email);
             parametros[11] = ObjConexion.crearParametro("@Celular", telefono);
             parametros[12] = ObjConexion.crearParametro("@Num_Legajo", numLegajo);
             parametros[13] = ObjConexion.crearParametro("@NombreUsuario", nombreUsuario);
             parametros[14] = ObjConexion.crearParametro("@Clave", clave);
             parametros[15] = ObjConexion.crearParametro("@Perfil", perfil);
             parametros[16] = ObjConexion.crearParametro("@FK_Cargo", indicadorPerfil);
             
        }

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
