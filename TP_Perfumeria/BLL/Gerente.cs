﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Gerente : Empleado
    {
        public Gerente(int numLegajo, string nombreUsuario, string clave, string perfil) : base(numLegajo, nombreUsuario, clave, perfil)
        {
        }

        public void generarRepoteVenta() { 
        }
    }
}