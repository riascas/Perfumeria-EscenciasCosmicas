using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Empleado
    {
		private int _numLegajo;

		public int NumLegajo
		{
			get { return _numLegajo; }
			set { _numLegajo = value; }
		}
		private string _nombreUsuario;

		public string NombreUsuario
		{
			get { return _nombreUsuario; }
			set { _nombreUsuario = value; }
		}
		private string _clave;

		public string Clave
		{
			get { return _clave; }
			set { _clave = value; }
		}
		private string _perfil;

		public string Perfil
		{
			get { return _perfil; }
			set { _perfil = value; }
		}
        public Empleado(int numLegajo, string nombreUsuario, string clave, string perfil)
        {
			this.NumLegajo = numLegajo;
			this.NombreUsuario = nombreUsuario;
			this.Clave = clave;
			this.Perfil = perfil;
        }
    }
}
