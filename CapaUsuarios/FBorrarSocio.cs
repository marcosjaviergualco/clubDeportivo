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
    public partial class FBorrarSocio : Form
    {
        List<Socio> socios;
        public FBorrarSocio(List<Socio> socios)
        {
            InitializeComponent();
            comboBoxSocios.DataSource = socios;
            this.socios = socios;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Socio soc = (Socio)comboBoxSocios.SelectedItem;
            List<Actividad> actividades = ((Socio)comboBoxSocios.SelectedItem).Actividades;

            foreach (var item in actividades)
            {
                item.removerSocio(soc);
            }

            this.socios.Remove(soc);

            this.Close();
        }

        public List<Socio> Socios
        {
            get { return socios; }
        }
    }
}
