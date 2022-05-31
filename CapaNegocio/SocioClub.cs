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

        public override float devolverCosto()
        {
            int numeroActs = this.darNumeroActividades();
            if (numeroActs > 5)
            {
                float montoTotal = cuotaSocial;

                for (int i = 5; i < base.actividadesAsociadas.Count; i++)
                {
                    montoTotal = montoTotal + base.actividadesAsociadas[i].dame50Porciento();
                }
                return montoTotal;
            }
            else
                return cuotaSocial;
        }

        public override void inscribir(Actividad act)
        {
            base.actividadesAsociadas.Add(act);
        }

        public int darNumeroActividades()
        {
            return base.actividadesAsociadas.Count;
        }

        public float CuotaSocial
        {
            get { return cuotaSocial; }
        }

        public override bool sosSocClub()
        {
            return true;
        }
    }
}
