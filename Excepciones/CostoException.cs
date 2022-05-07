using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CostoException : Exception
    {
        public CostoException()
            : base("Debe ingresar un costo mayor a cero.")
        {
        }
    }
}
