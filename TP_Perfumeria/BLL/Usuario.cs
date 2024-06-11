using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class Usuario 
    {
		private string _calle;

		public string Calle
		{
			get { return _calle; }
			set { _calle = value; }
		}
		private int _altura;

		public int Altura
		{
			get { return _altura; }
			set { _altura = value; }
		}
		private string _localidad;

		public string Localidad
		{
			get { return _localidad; }
			set { _localidad = value; }
		}
		private string _distrito;

		public string Distrito
		{
			get { return _distrito; }
			set { _distrito = value; }
		}
		private string _codPostal;

		public string CodPostal
		{
			get { return _codPostal; }
			set { _codPostal = value; }
		}
		private string _provincia;

		public string Provincia
		{
			get { return _provincia; }
			set { _provincia = value; }
		}
		private string _pais;

		public string Pais
		{
			get { return _pais; }
			set { _pais = value; }
		}

		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}
		private string _apellido;

		public string Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}
		private int _dni;

		public int DNI
		{
			get { return _dni; }
			set { _dni = value; }
		}
		private string _email;

		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}
		private int _telefono;

		public int Telefono
		{
			get { return _telefono; }
			set { _telefono = value; }
		}

		
    }
}
