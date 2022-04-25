using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    [Serializable]
    public class Actividad
    {
        private int id;
        private string descripcion;
        private DateTime hora;
        private string dia;
        private float costo;
        private int cantMaxParticipantes;
        private Profesor profesor;
        private List<Socio> socios;

        public Actividad(int unId, string unaDesc, string unDia, DateTime unaHora, float unCosto, int unCantMaxParticipantes, Profesor unProfesor)
        {
            id = unId;
            descripcion = unaDesc;
            dia = unDia;
            hora = unaHora;
            costo = unCosto;
            cantMaxParticipantes = unCantMaxParticipantes;
            profesor = unProfesor;
            socios = new List<Socio>();
        }

        public override string ToString()
        {
            // no funciona el \n (new line)
            return descripcion;
        }

        public float Costo
        {
            get {return costo;}
        }
    }
}
