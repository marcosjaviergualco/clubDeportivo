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
        private DateTime diaHora;
        private float costo;
        private int cantMaxParticipantes;
        private Profesor profesor;
        private List<Socio> socios;

        public Actividad(int unId, string unaDesc, DateTime unDiaHora, float unCosto, int unCantMaxParticipantes, Profesor unProfesor)
        {
            id = unId;
            descripcion = unaDesc;
            diaHora = unDiaHora;
            costo = unCosto;
            cantMaxParticipantes = unCantMaxParticipantes;
            profesor = unProfesor;
            socios = new List<Socio>();
        }
    }
}
