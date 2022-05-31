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
        Club club;
        List<Socio> socios;
        public FBorrarSocio(List<Socio> socios, Club club)
        {
            InitializeComponent();
            comboBoxSocios.DataSource = socios;
            this.socios = socios;
            this.club = club;
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
                this.club.desinscribir(item, soc); // llama a desinscribir despues de remover al socio de la actividad en memoria
            }

            //this.socios.Remove(soc);
            this.club.removerSocio(soc);

            this.Close();
        }

        public List<Socio> Socios
        {
            get { return socios; }
        }
    }
}
