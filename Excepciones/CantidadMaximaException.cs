using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CantidadMaximaException : Exception
    {
        public CantidadMaximaException() 
            :base("Cantidad máxima de participantes alcanzada")
        { 
        }
    }
}
