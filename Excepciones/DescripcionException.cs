using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DescripcionException : Exception
    {
        public DescripcionException()
            : base("Debe ingresar una descripción para la entidad en cuestión.")
        {
        }
    }
}
