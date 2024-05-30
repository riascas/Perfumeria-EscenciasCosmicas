using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Cliente : Usuario
    {
        private int _estado;

        public int Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

    }
}
