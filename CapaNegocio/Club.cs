using System;
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
            this.recuperarPagos();
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

        public bool agregar(Socio socio)
        {
            bool status = Db_datos.insertarSocio(pasarseSocioARelacional(socio));
            socios.Add(socio);

            return status;
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

        public bool inscribir(Actividad act, Socio soc)
        {
            bool todoBien = false;
            if (act != null && soc != null)
                todoBien = Db_datos.inscribir(this.pasarseActividadARelacional(act), this.pasarseSocioARelacional(soc));

            return todoBien;
        }

        public void desinscribir(Actividad act, Socio soc)
        {
            Db_datos.desinscribir(act.Id, soc.Dni);
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

        public ArrayList pasarseSocioARelacional(Socio soc)
        {
            ArrayList datos = new ArrayList();
            datos.Add(soc.Dni);
            datos.Add(soc.NombreCompleto);
            datos.Add(soc.Genero);
            datos.Add(soc.FechaNac);
            datos.Add(soc.Domicilio);
            if (soc.sosSocClub())
                datos.Add(((SocioClub)soc).CuotaSocial); //le pregunto si es socio club y si es, casteo a SocioClub y le pido la cuota
            else
                datos.Add(0);

            return datos;
        }

        public ArrayList pasarsePagoARelacional(Pago pago)
        {
            ArrayList datos = new ArrayList();
            datos.Add(pago.Id);
            datos.Add(pago.Monto);
            datos.Add(pago.TipoMoneda);
            datos.Add(pago.FechaPago);
            datos.Add(pago.Socio.Dni);

            return datos;
        }

        public ArrayList pasarseProfesorARelacional(Profesor profesor)
        {
            ArrayList datos = new ArrayList();
            datos.Add(profesor.Legajo);
            datos.Add(profesor.NombreCompleto);
            datos.Add(profesor.Domicilio);
            datos.Add(profesor.Genero);
            datos.Add(profesor.FechaNac);
            datos.Add(profesor.Dni);

            return datos;
        }

        public bool agregar(Profesor profesor)
        {
            bool status = Db_datos.insertarProfesor(pasarseProfesorARelacional(profesor));
            profesores.Add(profesor);

            return status;
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
            if (actividad!=null)
                actividad.vaciate();
        }

        public bool generarPago(Socio soc, DateTime fecha)
        {
            bool status = false;
            int unId;
            if (pagos.Count == 0)
                unId = 1000;
            else
                unId = pagos.Last().Id + 1;

            Pago pago = null;
            if(soc!=null)
                pago = new Pago(unId, soc.devolverCosto(), soc, fecha);

            if (pago != null)
            {
                this.agregar(pago);

                status = Db_datos.crearPago(pasarsePagoARelacional(pago));
            }

            return status;
        }

        public void removerProfesor(Profesor p)
        {
            Db_datos.borrarProfesor(p.Legajo);
            profesores.Remove(p);
        }
        public void removerSocio(Socio soc)
        {
            Db_datos.borrarSocio(soc.Dni);
            socios.Remove(soc);
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
        public static ArrayList buscaTusActividadesProfesor(string unLegajo)
        {
            ArrayList actividades_id = new ArrayList();
            ArrayList actividades = null;
            actividades = Db_datos.BuscarActividadesDeProfe(unLegajo);

            if (actividades.Count != 0 || actividades != null)
            {
                int id_actividad;

                for (int a = 0; a < actividades.Count; a++)
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

                    ArrayList actividades_profe = buscaTusActividadesProfesor(id_legajo);

                    if (actividades_profe.Count != 0)
                    {
                        for (int b = 0; b < actividades_profe.Count; b++)
                        {
                            for (int c = 0; c < Actividades.Count; c++)
                            {
                                if (Actividades[c].Id == int.Parse(actividades_profe[b].ToString()))
                                {
                                    unProfesor.agregate(Actividades[c]);
                                }
                            }


                        }

                    }

                    profesores.Add(unProfesor);
                }
                
            }
        }

        public void recuperarPagos()
        {
            ArrayList datosPagos = Db_datos.RecuperarPagos();
            Pago unPago = null;

            if (datosPagos.Count != 0)
            {
                int id_pago;
                float monto;
                string tipo_moneda;
                DateTime fecha_pago;
                string dni_socio;

                for (int a = 0; a < datosPagos.Count; a = a + 5)
                {
                    id_pago = int.Parse(datosPagos[a].ToString());
                    monto = float.Parse(datosPagos[a+1].ToString());
                    tipo_moneda = datosPagos[a+2].ToString();
                    fecha_pago = DateTime.ParseExact(datosPagos[a+3].ToString(), "d/M/yyyy HH:mm:ss", null);
                    dni_socio = datosPagos[a+4].ToString();
                    Socio socio = buscarSocio(dni_socio);
                    unPago = new Pago(id_pago, monto, socio, fecha_pago);
                    pagos.Add(unPago);
                }
                
            }
        }

        public Socio buscarSocio(string dni_socio)
        {
            string dniAux = null;
            int i = 0;

            do
            {
                dniAux = ((Socio)socios[i]).Dni;
                i++;

            } while (dniAux != dni_socio);

            return socios[i-1];
        }

    }
    }


    

