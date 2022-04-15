using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    [Serializable]
    public class Club
    {
        private List<Actividad> actividades;
        private List<Socio> socios;
        private List<Profesor> profesores;
        private List<Pago> pagos;

        public Club()
        {
            actividades = new List<Actividad>();
            socios = new List<Socio>();
            profesores = new List<Profesor>();
            pagos = new List<Pago>();
        }

        public List<Actividad> Actividades
        {
            get { return actividades; }
        }

        public List<Socio> Socios
        {
            get { return socios; }
        }

        public List<Pago> Pago
        {
            get { return pagos; }
        }

        public void agregar(Socio socioClub)
        {
            socios.Add(socioClub);
        }

        public void agregar(Actividad actividad)
        {
            actividades.Add(actividad);
        }

        public void agregar(Profesor profesor)
        {
            profesores.Add(profesor);
        }

        public void agregar(Pago pago)
        {
            pagos.Add(pago);
        }

        public bool Guardar()
        {
           return Datos.Guardar(this);
        }

        public static Club Recuperar()
        {
            Club c = (Club)Datos.Recuperar();
            if (c == null)
            {
                c = new Club();
            }
            return c;
        }
    }
}
