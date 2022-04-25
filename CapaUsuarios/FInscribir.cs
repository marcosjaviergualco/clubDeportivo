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
    public partial class FInscribir : Form
    {
        private Socio s;
        private Actividad a;
        public FInscribir(List<Actividad> actividades, List<Socio> socios)
        {
            InitializeComponent();
            comboBoxActividades.DataSource = actividades;
            comboBoxSocios.DataSource = socios;
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            try
            {
                s = (Socio)comboBoxSocios.SelectedItem;
                s.inscribir((Actividad)comboBoxActividades.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
