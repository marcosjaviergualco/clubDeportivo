using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    [Serializable]
    public abstract class Socio:Persona
    {
        public Socio(string unDni, string unNombreCompleto, char unGenero, DateTime unaFechaNac, string unDomicilio)
            :base(unDni, unNombreCompleto, unGenero, unaFechaNac, unDomicilio)
        {
           
        }

        public abstract float devolverCosto();

        public abstract void inscribir(Actividad act);

        public override string ToString()
        {
            String listaActividades = "";
            foreach (var item in actividadesAsociadas)
            {
                listaActividades = listaActividades + item.ToString();
            }
            return nombreCompleto + " - " + listaActividades;
        }

        public void removerActividad(Actividad act)
        {
            base.actividadesAsociadas.Remove(act);
        }

        public void eliminateDeLaActividad(Actividad actividad) 
        {
            actividadesAsociadas.Remove(actividad);
        }

    }
}
