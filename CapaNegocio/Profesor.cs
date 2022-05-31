using System;
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
            return legajo + " - " + nombreCompleto + " - ";
        }

        public void agregate(Actividad act)
        {
            actividadesAsociadas.Add(act);
        }

        public void removerActividad(Actividad act)
        {
            base.actividadesAsociadas.Remove(act);
        }

        public List<Actividad> ActividadesAsociadas
        {
            get { return base.actividadesAsociadas; }
        }

        public string Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

    }
}
