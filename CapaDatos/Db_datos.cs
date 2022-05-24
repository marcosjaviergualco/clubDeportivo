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

        public static ArrayList RecuperarSocios() {


            ArrayList datos = new ArrayList();

            try
            {

                string strCmd = "SELECT * FROM Socios ORDER BY dni_socio";
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

                string strCmd = "SELECT * FROM Profesor ORDER BY legajo";
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




    }
}
