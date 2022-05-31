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
            this.recuperarTodo();
            this.recuperarProfesores();
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

        public bool agregar(Actividad actividad)
        {
            bool todoBien = false;
            if (actividad != null)
            {
                todoBien = Db_datos.insertarActividad(pasarseActividadARelacional(actividad));
                if (todoBien)
                    actividades.Add(actividad);
            }
            return todoBien;
        }

        public bool modificar(Actividad actividad)
        {
            bool todoBien = false;
            if (actividad != null)
            {
                todoBien = Db_datos.actualizarActividad(this.pasarseActividadARelacional(actividad));
            }
            
            return todoBien;
        }

        public ArrayList pasarseActividadARelacional(Actividad act)
        {
            ArrayList datos = new ArrayList();
            datos.Add(act.Id);
            datos.Add(act.Descripcion);
            datos.Add(act.Dia);
            datos.Add(act.Hora);
            datos.Add(act.CantMaxParticipantes);
            datos.Add(act.Costo);
            if(act.Profesor != null)
            {
                datos.Add(act.Profesor.Legajo);
            }
            else
            {
                datos.Add("");
            }
            
            return datos;
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
            Db_datos.eliminarActividad(actividad.Id);
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
            int unId;
            string unaDesc;
            string unDia;
            DateTime unaHora;
            float unCosto;
            int unCantMaxParticipantes;
            Profesor unProfesor = null;
            string legajo;
            ArrayList datosTodasAct = Db_datos.RecuperarActividades();

            for (int a = 0; a < datosTodasAct.Count; a = a + 7)
            {
                unId = int.Parse(datosTodasAct[a].ToString());
                unaDesc = datosTodasAct[a + 1].ToString();
                unDia = datosTodasAct[a + 2].ToString();
                unaHora = DateTime.ParseExact(datosTodasAct[a + 3].ToString(), "HH:mm:ss", null);
                unCantMaxParticipantes = int.Parse(datosTodasAct[a + 4].ToString());
                unCosto = float.Parse(datosTodasAct[a + 5].ToString());
                legajo = datosTodasAct[a + 6].ToString();
                unProfesor = buscarProfesor(legajo);

                Actividad unaAct = new Actividad(unId, unaDesc, unDia, unaHora, unCosto, unCantMaxParticipantes, unProfesor);

                Actividades.Add(unaAct);
            }


            //Recuperar socio
            Socio socio = null;
            string unDni;
            string nombreCompleto;
            string characters;
            DateTime unaFechaNac;
            string unDomicilio;
            float unaCuotaSocial;

            ArrayList datosTodas = Db_datos.RecuperarSocios();
            //todos los socios recuperados.
            for (int m = 0; m < datosTodas.Count; m = m + 6)
            {
                //cada uno de los elementos de un socio.
                //ArrayList datos_socios = datosTodas[m];

                unDni = datosTodas[m].ToString();
                nombreCompleto = datosTodas[m + 1].ToString();
                characters = datosTodas[m + 2].ToString();
                char unGenero = characters.ToCharArray()[0];
                unaFechaNac = DateTime.ParseExact(datosTodas[m + 3].ToString(), "d/M/yyyy HH:mm:ss", null);
                unDomicilio = datosTodas[m + 4].ToString();
                unaCuotaSocial = float.Parse(datosTodas[m + 5].ToString());


                if (unaCuotaSocial == null)
                {
                    //socio act
                    socio = new SocioActividad(unDni, nombreCompleto, unGenero, unaFechaNac, unDomicilio);
                   
                }
                else
                {
                    //socio club
                    socio = new SocioClub(unDni, nombreCompleto, unGenero, unaFechaNac, unDomicilio, unaCuotaSocial);
                   
                }

                ArrayList actividades_socio = buscaTusActividades(unDni);

                if (actividades_socio.Count != 0)
                {
                    for (int a = 0; a < actividades_socio.Count; a++)
                    {
                        for(int b=0; b < Actividades.Count; b++)
                        {
                            if (Actividades[b].Id == int.Parse(actividades_socio[a].ToString()))
                            {
                                socio.inscribir(Actividades[b]);
                            }
                        }
                        

                    }

                }

                socios.Add(socio);

            }

          

            

        }//Cierre public recuperar todo


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
        public static Profesor buscarProfesor(string legajo) {

                ArrayList profesor = Db_datos.BuscarUnProfesor(legajo);
                Profesor unProfesor = null;

 
                if (profesor.Count != 0)
                {
                    string unDni;
                    string unNombreCompleto;
                    char unGenero;
                    DateTime unaFechaNac;
                    string unDomicilio;
                    string unLegajo;
                    string characters;

                    for (int a = 0; a < profesor.Count; a = a + 6)
                    {
                        unLegajo = profesor[a].ToString();
                        unNombreCompleto = profesor[a + 1].ToString();
                        unDomicilio = profesor[a + 2].ToString();
                        characters = profesor[a + 3].ToString();
                        unGenero = characters.ToCharArray()[0];
                        unaFechaNac = DateTime.ParseExact(profesor[a + 4].ToString(), "d/M/yyyy HH:mm:ss", null);
                        unDni = profesor[a + 5].ToString();

                        unProfesor = new Profesor(unDni, unNombreCompleto, unGenero, unaFechaNac, unDomicilio, unLegajo);
                    }
                }
                return unProfesor;

            }
        public static ArrayList buscaTusActividades(string unDni)
        {
            ArrayList actividades_id = new ArrayList();
            ArrayList actividades = null;
            actividades = Db_datos.BuscarActividadesDeSocio(unDni);
            
            if (actividades.Count != 0 || actividades != null)
            {
                int id_actividad;

                for (int a = 0; a < actividades.Count; a = a + 2)
                {
                    id_actividad = int.Parse(actividades[a].ToString());
                    actividades_id.Add(id_actividad);
                }
            }

            return actividades_id;


        }

        public void recuperarProfesores(){
            ArrayList profesoresBD = Db_datos.RecuperarProfesores();
            Profesor unProfesor = null;

            if (profesoresBD.Count != 0)
            {
                string id_legajo;
                string nombre_completo;
                string unDomicilio;
                char unGenero;
                DateTime fecha_de_nacimiento;
                string dni_profesor;
                string characters;

                for (int a = 0; a < profesoresBD.Count; a = a + 6)
                {
                    id_legajo = profesoresBD[a].ToString();
                    nombre_completo = profesoresBD[a + 1].ToString();
                    unDomicilio = profesoresBD[a + 2].ToString();
                    characters = profesoresBD[a + 3].ToString();
                    unGenero = characters.ToCharArray()[0];
                    fecha_de_nacimiento = DateTime.ParseExact(profesoresBD[a + 4].ToString(), "d/M/yyyy HH:mm:ss", null);
                    dni_profesor = profesoresBD[a + 5].ToString();

                    unProfesor = new Profesor(dni_profesor, nombre_completo, unGenero, fecha_de_nacimiento, unDomicilio, id_legajo);
                }
                profesores.Add(unProfesor);
            }
        }


        }
    }


    

