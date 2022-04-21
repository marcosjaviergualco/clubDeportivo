using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    [Serializable]
    public abstract class Persona
    {


        protected string dni;
        protected string nombreCompleto;
        protected char genero;
        protected DateTime fechaNac;
        protected string domicilio;
        protected List<Actividad> actividadesAsociadas;
    

    public Persona(string unDni, string unNombreCompleto, char unGenero, DateTime unaFechaNac, string unDomicilio)
    {
        dni = unDni;
        nombreCompleto = unNombreCompleto;
            genero = unGenero;
            fechaNac = unaFechaNac;
            domicilio = unDomicilio;
            actividadesAsociadas = null;
    }

        public abstract void inscribir(Actividad act);
    }
}
