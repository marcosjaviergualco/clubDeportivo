﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
   // [Serializable]
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
            set { actividades = value; }
        }

        public List<Socio> Socios
        {
            get { return socios; }
            set { socios = value; }
        }

        public List<Pago> Pago
        {
            get { return pagos; }
        }

        public List<Profesor> Profesores
        {
            get { return profesores; }
        }

        public void agregar(Socio socio)
        {
            socios.Add(socio);
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

        public void removerActividad(Actividad actividad)
        {
            actividades.Remove(actividad);
        }

        public void removerSocioActividad(Actividad actividad)
        {
            actividad.vaciate();
        }

        public void generarPago(Socio soc, DateTime fecha)
        {
            int unId;
            if (pagos.Count == 0)
                unId = 1000;
            else
                unId = pagos.Last().Id + 1;

            Pago pago = new Pago(unId, soc.devolverCosto(), soc);

            this.agregar(pago);
        }

        public void removerProfesor(Profesor p)
        {
            profesores.Remove(p);
        }

        //Base de datos
        public static void PonerPathABaseAccess(string l)
        {
            Db_datos.PonerPathBaseAccess(l);
        }


        public void recuperarTodo()
        {
            //Recuperar socio
            Socio socio = null;
            int unDni;
            string nombreCompleto;
            string unGenero;
            DateTime unaFechaNac;
            string unDomicilio;
            float unaCuotaSocial;

            ArrayList datosTodas = Db_datos.RecuperarSocios();
            //todos los socios recuperados.
            for (int m = 0; m <= datosTodas.Count; m++) {
                //cada uno de los elementos de un socio.
                ArrayList datos_socios = datosTodas[m];

                        unDni = int.Parse(datos_socios[0].ToString());
                        nombreCompleto = datos_socios[1].ToString();
                        unaFechaNac = datos_socios[2];
                        unDomicilio = datos_socios[2];
                        unGenero = datos_socios[3];
                        unaCuotaSocial = datos_socios[4];

                    if (unaCuotaSocial == null) {
                        //socio act
                        socio = new Socio(unDni, unNombreCompleto, unGenero, unaFechaNac, unDomicilio);
                        socios.Add(socio);
                    }
                    else {
                        //socio club
                        socio = new Socio(unDni, unNombreCompleto, unGenero, unaFechaNac, unDomicilio, unaCuotaSocial);
                        socios.Add(socio);
                    }
                }

            RecuperarAct();





            }
            /*
            List<ArrayList> datosPersonas = Datos.RecuperarPersonas();
            foreach (ArrayList datosPer in datosPersonas)
            {
                dni = int.Parse(datosPer[0].ToString());
                nombre = datosPer[1].ToString();
                per = new Persona(dni, nombre);
                lista.Add(per);
            }
            */
        }

    }
}
