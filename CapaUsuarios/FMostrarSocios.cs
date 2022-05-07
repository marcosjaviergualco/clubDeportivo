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
    public partial class FMostrarSocios : Form
    {
        public FMostrarSocios(List<Socio> socios)
        {
            InitializeComponent();
            listBoxSocios.DataSource = socios;
            listBoxSocios.ClearSelected();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
