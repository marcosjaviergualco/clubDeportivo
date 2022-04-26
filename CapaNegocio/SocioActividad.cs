using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    [Serializable]
    public sealed class SocioActividad:Socio
    {
        public SocioActividad(string unDni, string unNombreCompleto, char unGenero, DateTime unaFechaNac, string unDomicilio)
            : base(unDni, unNombreCompleto, unGenero, unaFechaNac, unDomicilio)
        {

        }

        public override float devolverCosto()
        {
            List<Actividad> lista = base.actividadesAsociadas;
            float total = 0;

            foreach (var item in lista)
            {
                total = total + item.Costo;
            }

            return total;
        }

        public override void inscribir(Actividad act)
        {
            base.actividadesAsociadas.Add(act);
        }
    }
}
