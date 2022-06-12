using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio ;

namespace UIWeb
{
    public partial class Inicio : System.Web.UI.Page
    {
        Club cl;
        string lugarBase;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cl = new Club();
                Session["administra"] = cl;
                refrescarLista();
                //lugarBase = Server.MapPath; //solo para usar Access u otra base que no corra en el Servidor SQL
            }

        }
        public void recuperarAdmin()
        {
            cl = (Club)Session["administra"];
        }
        public void refrescarLista()
        {

            //if(ListBox1.Items.Count>0)
            ListBox1.Items.Clear();// Saco todo para que no se repitan
            ListBox2.Items.Clear();
            ListBox3.Items.Clear();
            recuperarAdmin();
            List<Socio> lsocios = cl.Socios;
            List<Actividad> lactividades = cl.Actividades;
            List<Profesor> lprofesores = cl.Profesores;

            for (int i = 0; i < lsocios.Count; i++)
                ListBox1.Items.Add(lsocios[i].ToString());

            for (int i = 0; i < lactividades.Count; i++)
                ListBox2.Items.Add(lactividades[i].ToString());

            for (int i = 0; i < lprofesores.Count; i++)
                ListBox3.Items.Add(lprofesores[i].ToString());

        }

        protected void btnVerSocio_Click(object sender, EventArgs e)
        {

        }

        protected void btnVerAct_Click(object sender, EventArgs e)
        {

        }

        protected void btnVerProf_Click(object sender, EventArgs e)
        {

        }
    }
}