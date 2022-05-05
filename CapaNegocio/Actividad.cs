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
            if (profesor != null)
                return descripcion+" "+costo+" "+dia+" "+profesor.ToString();
            else
                return descripcion + " " + costo + " " + dia + " " + " SIN PROFESOR";
        }

        public float Costo
        {
            get {return costo;}
            set { costo = value; }
        }

        public float dame50Porciento()
        {
            return (float)(costo * (0.5));
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Dia
        {
            get { return dia; }
            set { dia = value; }
        }

        public DateTime Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public int CantMaxParticipantes
        {
            get { return cantMaxParticipantes; }
            set { cantMaxParticipantes = value; }
        }

        public Profesor Profesor
        {
            get { return profesor; }
            set { profesor = value; }
        }

        public List<Socio> Socios
        {
            get { return socios; }
        }

        public void removerSocio(Socio soc)
        {
            socios.Remove(soc);
        }

        public void removerProfe()
        {
            profesor = null;
        }

        public void vaciate()
        {
            foreach (var unSocio in socios)
            {
                unSocio.eliminateDeLaActividad(this);
            }
            profesor.removerActividad(this);
        }

        public void agregar(Socio s)
        {
            socios.Add(s);
        }
    }
}
