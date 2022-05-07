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
    public partial class FMostrar : Form
    {
        public FMostrar(List<Actividad> actividades)
        {
            InitializeComponent();
            listBoxMostrar.DataSource = actividades;
            listBoxMostrar.ClearSelected();

        }

        private void btnCerrarMostrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
