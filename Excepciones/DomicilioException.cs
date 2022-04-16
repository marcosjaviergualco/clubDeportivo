using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DomicilioException : Exception
    {
        public DomicilioException()
            : base("Domicilio en blanco")
        {
        }
    }
}
