﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    [Serializable]
    public class Profesor:Persona
    {
        private string legajo;

        public Profesor(string unDni, string unNombreCompleto, char unGenero, DateTime unaFechaNac, string unDomicilio, string unLegajo)
            :base(unDni, unNombreCompleto, unGenero, unaFechaNac, unDomicilio)
        {
            legajo = unLegajo;
        }

        public override string ToString()
        {
            return legajo + " - " + nombreCompleto;
        }
    }
}
