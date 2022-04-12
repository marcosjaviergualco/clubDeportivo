using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Pago
    {
        private int id;
        private float monto;
        private string tipoMoneda;
        private Socio socio;
        public Pago(int unId, float unMonto, string unTipoMoneda, Socio unSocio)
        {
            id = unId;
            monto = unMonto;
            tipoMoneda = unTipoMoneda;
            socio = unSocio;
        }
    }
}
