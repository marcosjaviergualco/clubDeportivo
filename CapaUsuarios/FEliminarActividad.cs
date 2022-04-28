using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaUsuarios
{
    public partial class FEliminarActividad : Form
    {
        //List<Actividad> actividades;
        //List<Socio> socios;
        Actividad actividad;
        public FEliminarActividad(List<Actividad> actividades)
        {
            InitializeComponent();
            comboBoxActividades.DataSource = actividades;
            //this.actividades = actividades;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            actividad = ((Actividad)(comboBoxActividades.SelectedItem));

            // todo esto lo debe hacer la actividad en Capa Negocio
            //socios = actividad.Socios;
            
            /*foreach (var item in socios)
            {
                item.removerActividad(actividad);
            }

            actividades.Remove(actividad); */

            // volver a actualizar el listbox dentro de este evento

            this.Close();
        }

        /*public List<Actividad> Actividades
        {
            get { return actividades; }
            set { actividades = value; }
        }

        public List<Socio> Socios
        {
            get { return socios; }
            set { socios = value; }
        }*/

        public Actividad Actividad
        {
            get { return actividad; }
        }
    }
}
