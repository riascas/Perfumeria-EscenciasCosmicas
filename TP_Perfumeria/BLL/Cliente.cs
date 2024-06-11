using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Cliente : Usuario
    {
        private int _estado;

        public int Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        /*public Cliente(string nombre, string apellido, int dni, string email, int telefono) : base(nombre, apellido, dni, email, telefono)
        {
        }*/

               

    }
}
