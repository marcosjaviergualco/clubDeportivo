using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    [Serializable]
    public sealed class SocioClub:Socio
    {
        private float cuotaSocial;

        public SocioClub(string unDni, string unNombreCompleto, char unGenero, DateTime unaFechaNac, string unDomicilio, float unaCuotaSocial)
            :base(unDni, unNombreCompleto, unGenero, unaFechaNac, unDomicilio)
        {
            cuotaSocial = unaCuotaSocial;
        }

    }
}
