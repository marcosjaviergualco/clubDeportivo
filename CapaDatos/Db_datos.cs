using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace CapaDatos
{
    public class Db_datos
    {
        //Para Access 2000-2003
        private static string LugarBase;
        private static string Str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
        //Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\bin\Debug\Persistencia\basePersonas.mdb
        private static OleDbConnection Con;
        private static OleDbCommand Cmd;
        private static OleDbDataAdapter Da;
        //Para todos
        private static DataSet Ds;
        public static void PonerPathBaseAccess(string l)
        {
            LugarBase = l + @"\Persistencia\club_deportivo.mdb";
            Db_datos.Str += LugarBase;
        }

        public static ArrayList RecuperarPagos()
        {
            ArrayList datos = new ArrayList();
            try
            {
                string strCmd = "SELECT * FROM Pago ORDER BY id_pago";
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[1].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[2].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[3].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[4].ToString());

                }
                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return datos;
        }

        public static ArrayList RecuperarSocios() {


            ArrayList datos = new ArrayList();

            try
            {

                string strCmd = "SELECT * FROM Socio ORDER BY dni_socio";
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[1].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[2].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[3].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[4].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[5].ToString());

                }
                /*
                List<ArrayList> datosP = new List<ArrayList>();
                ArrayList persona;
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    persona = new ArrayList();
                    
                    for(int j=0;j<2;j++)
                        persona.Add(Ds.Tables[0].Rows[i].ItemArray[j].ToString());

                    datosP.Add(persona);
                }
                */
                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return datos;


        }

        public static ArrayList RecuperarProfesores()
        {
            ArrayList datos = new ArrayList();

            try
            {
                string strCmd = "SELECT * FROM Profesor ORDER BY id_legajo";
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[1].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[2].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[3].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[4].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[5].ToString());
                }
                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return datos;
        }

        public static ArrayList RecuperarActividades()
        {
            ArrayList datos = new ArrayList();
            try
            {
                string strCmd = "SELECT * FROM Actividad ORDER BY id_actividad";
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[1].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[2].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[3].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[4].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[5].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[6].ToString());

                }
                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch(Exception ex)
            {
                string error = ex.Message;
            }
            return datos;
        }

        public static ArrayList RecuperarActividadesSocios()
        {
            ArrayList datos = new ArrayList();
            try
            {
                string strCmd = "SELECT * FROM Actividad ORDER BY id_actividad";
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[1].ToString());
                }
                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return datos;
        }


        public static ArrayList BuscarUnProfesor(string legajo)
        {
            ArrayList datos = null;
            datos = new ArrayList();
            
            try
            {
               // string consulta=concat()
                string strCmd = "SELECT * FROM Profesor WHERE id_legajo='"+legajo+"'";
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[1].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[2].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[3].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[4].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[5].ToString());
                }
                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return datos;

        }

        public static ArrayList BuscarActividadesDeSocio(string unDni)
        {
            ArrayList datos = new ArrayList();
            try
            {
                string strCmd = "SELECT * FROM Actividad_Socio WHERE dni_socio='" + unDni + "'";
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[1].ToString());
                }
                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return datos;

        }
        public static ArrayList BuscarActividadesDeProfe(string unLegajo)
        {
            ArrayList datos = new ArrayList();
            try
            {
                string strCmd = "SELECT * FROM Actividad WHERE legajo_profesor='" + unLegajo + "'";
                Con = new OleDbConnection(Str);
                Con.Open();
                Da = new OleDbDataAdapter(strCmd, Con);
                Ds = new DataSet();
                Da.Fill(Ds);

                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    datos.Add(Ds.Tables[0].Rows[i].ItemArray[0].ToString()); // solo quiero el id_actividad para buscarla en memoria
                }
                Con.Close();
                Ds.Dispose();
                Da.Dispose();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return datos;

        }

        public static bool crearPago(ArrayList datos)
        {
            bool todoBien = false;
            if (datos != null && datos.Count == 5)
            {
                try
                {
                    int id_pago = int.Parse(datos[0].ToString());
                    float monto = float.Parse(datos[1].ToString());
                    string tipo_moneda = datos[2].ToString();
                    string fecha_pago = datos[3].ToString();
                    string format1Dni = datos[4].ToString().Replace(" ", "");
                    string dni_socio = format1Dni.Replace(".", "");
                    string strCmd = "INSERT INTO Pago(id_pago,monto,tipo_moneda,fecha_pago,dni_socio) " +
                        "VALUES ("+id_pago+","+monto+",'"+tipo_moneda+"','"+fecha_pago+"','"+dni_socio+"')";
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoBien = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return todoBien;
        }

        public static bool insertarActividad(ArrayList datos)
        {
            bool todoBien = false;
            if (datos != null && datos.Count == 7)
            {
                try
                {
                    int id = int.Parse(datos[0].ToString());
                    string descripcion = datos[1].ToString();
                    string dia = datos[2].ToString();
                    string hora = datos[3].ToString();
                    string cant_max_participantes = datos[4].ToString();
                    float costo = float.Parse(datos[5].ToString());
                    string legajo_profesor = datos[6].ToString();
                    string strCmd = "INSERT INTO Actividad(id_actividad,descripcion,dia,hora,cantidad_max_participantes,costo,legajo_profesor) " +
                        "VALUES (" + id + "," + "'" + descripcion + "','" + dia + "','" + hora + "','" + cant_max_participantes + "'," + costo + ",'" + legajo_profesor + "')";
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoBien = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return todoBien;
        }

        public static bool actualizarActividad(ArrayList datos)
        {
            bool todoBien = false;
            if (datos != null && datos.Count == 7)
            {
                try
                {
                    int id = int.Parse(datos[0].ToString());
                    string descripcion = datos[1].ToString();
                    string dia = datos[2].ToString();
                    string hora = datos[3].ToString().Substring(datos[3].ToString().IndexOf(" ") + 1);
                    string cant_max_participantes = datos[4].ToString();
                    float costo = float.Parse(datos[5].ToString());
                    string legajo_profesor = datos[6].ToString();
                    string strCmd = "UPDATE Actividad " +
                        "SET id_actividad = " + id + ","
                        + " descripcion= '" + descripcion + "',"
                        + " dia= '" + dia + "',"
                        + " hora= '" + hora + "',"
                        + " cantidad_max_participantes= '" + cant_max_participantes + "',"
                        + " costo= '" + costo + "',"
                        + " legajo_profesor = '" + legajo_profesor + "'" +
                        " WHERE id_actividad = " + id;
                        
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoBien = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return todoBien;
        }

        public static void eliminarActividad(int idActividad)
        {
            try
            {
                string strCmd = "DELETE FROM Actividad WHERE id_actividad=" + idActividad + ";";
                Con = new OleDbConnection(Str);
                Con.Open();
                Cmd = new OleDbCommand(strCmd, Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
                Cmd.Dispose();

            }
            catch (Exception ex)
            {
                string error = ex.Message;

            }

        }

        public static bool inscribir(ArrayList datosAct, ArrayList datosSoc)
        {
            bool todoBien = false;
            if (datosAct != null && datosSoc != null && datosAct.Count == 7 && datosSoc.Count == 6)
            {
                try
                {
                    int id_actividad = int.Parse(datosAct[0].ToString());
                    string format1Dni = datosSoc[0].ToString().Replace(" ", "");
                    string dni_socio = format1Dni.Replace(".", "");
                    string strCmd = "INSERT INTO Actividad_Socio(id_actividad,dni_socio) " +
                        "VALUES (" + id_actividad + ",'" + dni_socio + "')";

                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoBien = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return todoBien;
        }

        public static void desinscribir(int id_actividad, string dni_socio)
        {
            try
            {
                string strCmd = "DELETE FROM Actividad_Socio WHERE id_actividad=" + id_actividad + " AND " + "dni_socio='" + dni_socio+"';";
                Con = new OleDbConnection(Str);
                Con.Open();
                Cmd = new OleDbCommand(strCmd, Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
                Cmd.Dispose();

            }
            catch (Exception ex)
            {
                string error = ex.Message;

            }
        }

        public static bool insertarProfesor(ArrayList datos)
        {
            bool todoBien = false;
            if (datos != null && datos.Count == 6)
            {
                try
                {
                    string id_legajo = datos[0].ToString();
                    string nombre_completo = datos[1].ToString();
                    string domicilio = datos[2].ToString();
                    string genero = datos[3].ToString();
                    string fecha_de_nacimiento = datos[4].ToString();
                    string format1Dni = datos[5].ToString().Replace(" ", "");
                    string dni_profesor = format1Dni.Replace(".", "");
                    string strCmd = "INSERT INTO Profesor(id_legajo,nombre_completo,domicilio,genero,fecha_de_nacimiento,dni_profesor) " +
                        "VALUES ('" + id_legajo + "','" +nombre_completo+ "','" + domicilio + "','" + genero + "','" + fecha_de_nacimiento + "','" + dni_profesor + "')";
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoBien = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return todoBien;
        }

        public static void borrarProfesor(string id_legajo)
        {
            try
            {
                string strCmd = "DELETE FROM Profesor WHERE id_legajo='" + id_legajo + "';";
                Con = new OleDbConnection(Str);
                Con.Open();
                Cmd = new OleDbCommand(strCmd, Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
                Cmd.Dispose();

            }
            catch (Exception ex)
            {
                string error = ex.Message;

            }

        }

        public static void borrarSocio(string dni_socio_string)
        {
            try
            {
                int dni_socio = int.Parse(dni_socio_string);
                string strCmd = "DELETE FROM Socio WHERE dni_socio=" + dni_socio + ";";
                Con = new OleDbConnection(Str);
                Con.Open();
                Cmd = new OleDbCommand(strCmd, Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
                Cmd.Dispose();

            }
            catch (Exception ex)
            {
                string error = ex.Message;

            }

        }

        public static bool insertarSocio(ArrayList datos)
        {
            bool todoBien = false;
            if (datos != null && datos.Count == 6)
            {
                try
                {
                    string format1Dni = datos[0].ToString().Replace(" ", "");

                    string format2Dni = format1Dni.Replace(".", "");
                    int dni_socio = int.Parse(format2Dni);
                    string nombre_completo = datos[1].ToString();
                    string genero = datos[2].ToString();
                    string fecha_de_nacimiento = datos[3].ToString();
                    string domicilio = datos[4].ToString();
                    float cuota_social = float.Parse(datos[5].ToString());
                    string strCmd = "INSERT INTO Socio(dni_socio,nombre_completo,genero,fecha_de_nacimiento,domicilio,cuota_social) " +
                        "VALUES (" + dni_socio + ",'" + nombre_completo + "','" + genero + "','" + fecha_de_nacimiento + "','" + domicilio + "'," + cuota_social + ")";
                    Con = new OleDbConnection(Str);
                    Con.Open();
                    Cmd = new OleDbCommand(strCmd, Con);
                    Cmd.ExecuteNonQuery();
                    Con.Close();
                    Cmd.Dispose();
                    todoBien = true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;

                }
            }
            return todoBien;
        }

    }
}
