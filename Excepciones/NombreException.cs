using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NombreException : Exception
    {
        public NombreException()
            : base("Nombre y apellido en blanco")
        {
        }
    }

    
}
