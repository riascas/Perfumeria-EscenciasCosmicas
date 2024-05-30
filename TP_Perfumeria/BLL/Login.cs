using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Login
    {
        //private string _usuario;
        //private string _clave;

        public bool IniciarSesion (string usuario, string clave) 
        {
            Conexion objConexion = new Conexion();
            DataTable dt = objConexion.LeerPorComando("select [NombreUsuario], [Clave], [Perfil] from [Perfumeria_2.0].[dbo].[Empleados]");

            foreach (DataRow fila in dt.Rows) 
            {
                if (fila["NombreUsuario"].ToString() == usuario && fila["Clave"].ToString() == clave)
                {                    
                    return true;
                }
            }
            return false;
        }

        public List<string> PerfilAdmin (List<string> nombreUsuario)
        {
            Conexion objConexion = new Conexion();
            DataTable per = objConexion.LeerPorComando("select [NombreUsuario], [Perfil] from [Perfumeria_2.0].[dbo].[Empleados]");
            List<string> usuariosAdmin = new List<string>();

            foreach (DataRow fila in per.Rows)
            {
                if (fila["Perfil"].ToString() == "admin")
                {
                    usuariosAdmin.Add(fila["NombreUsuario"].ToString());
                }                
            }
            return usuariosAdmin;
        }
        public List<string> PerfilGerente(List<string> nombreUsuario)
        {
            Conexion objConexion = new Conexion();
            DataTable per = objConexion.LeerPorComando("select [NombreUsuario], [Perfil] from [Perfumeria_2.0].[dbo].[Empleados]");
            List<string> usuariosGerente = new List<string>();

            foreach (DataRow fila in per.Rows)
            {
                if (fila["Perfil"].ToString() == "gerente")
                {
                    usuariosGerente.Add(fila["NombreUsuario"].ToString());
                }
            }
            return usuariosGerente;
        }
        public List<string> PerfilVendedor(List<string> nombreUsuario)
        {
            Conexion objConexion = new Conexion();
            DataTable per = objConexion.LeerPorComando("select [NombreUsuario], [Perfil] from [Perfumeria_2.0].[dbo].[Empleados]");
            List<string> usuariosVendedor = new List<string>();

            foreach (DataRow fila in per.Rows)
            {
                if (fila["Perfil"].ToString() == "vendedor")
                {
                    usuariosVendedor.Add(fila["NombreUsuario"].ToString());
                }
            }
            return usuariosVendedor;
        }
        public List<string> PerfilEncargado(List<string> nombreUsuario)
        {
            Conexion objConexion = new Conexion();
            DataTable per = objConexion.LeerPorComando("select [NombreUsuario], [Perfil] from [Perfumeria_2.0].[dbo].[Empleados]");
            List<string> usuariosEncargado = new List<string>();

            foreach (DataRow fila in per.Rows)
            {
                if (fila["Perfil"].ToString() == "encargado")
                {
                    usuariosEncargado.Add(fila["NombreUsuario"].ToString());
                }
            }
            return usuariosEncargado;
        }
    }    
}
