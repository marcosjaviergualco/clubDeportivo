using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    [Serializable]

    public class Pago
    {

        private int id;
        private float monto;
        private string tipoMoneda;
        private DateTime fechaPago;
        private Socio socio;
        public Pago(int unId, float unMonto, Socio unSocio)
        {
            id = unId;
            monto = unMonto;
            tipoMoneda = "PESOS ARG $";
            socio = unSocio;
            fechaPago = DateTime.Now;
        }

        public int Id
        {
            get { return id; }
        }

        public override string ToString()
        {
            return id + " - " + tipoMoneda + " " + monto + " - " + socio;
        }
    }
}
