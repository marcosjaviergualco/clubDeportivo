using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniException : Exception
    {
        public DniException()
            : base("Debe especcificar un DNI.")
        {
        }
    }
}
