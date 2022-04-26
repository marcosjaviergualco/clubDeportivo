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
        List<Actividad> actividades;
        public FEliminarActividad(List<Actividad> actividades)
        {
            InitializeComponent();
            comboBoxActividades.DataSource = actividades;
            this.actividades = actividades;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Actividad actividad = ((Actividad)(comboBoxActividades.SelectedItem));

            List<Socio> socios = actividad.Socios;

            foreach (var item in socios)
            {
                item.removerActividad(actividad);
            }

            actividades.Remove(actividad);

            this.Close();
        }

        public List<Actividad> Actividades
        {
            get { return actividades; }
            set { actividades = value; }
        }
    }
}
