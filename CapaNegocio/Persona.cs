using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Persona
    {
        private int dni;
        private string nombreCompleto;
        private char genero;
        private DateTime fechaNac;
        private string domicilio;
        private List<Actividad> actividadesAsociadas;
    }
}
