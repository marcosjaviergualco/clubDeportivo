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
    public partial class FCrearActividad : Form
    {

        private Actividad act;
        public FCrearActividad(List<Profesor> profesores)
        {
            InitializeComponent();
            listBoxProfesores.DataSource = profesores;
            listBoxProfesores.ClearSelected();
            act = null;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int unId = int.Parse(this.textBoxId.Text);
            string unaDesc = this.textBoxDesc.Text;
            DateTime unDiaYHora = this.dateTimePickerDiaYHora.Value;
            float unCosto = float.Parse(this.textBoxCosto.Text);
            int unaCantMax = int.Parse(this.textBoxCantMax.Text);
            Profesor prof = (Profesor)listBoxProfesores.SelectedItem;

            act = new Actividad(unId, unaDesc, unDiaYHora, unCosto, unaCantMax, prof);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            act = null;
            this.Close();
        }

        public Actividad Actividad
        {
            get { return act; }
        }

        public void MostrarMensaje(string coso)
        {
            MessageBox.Show(coso);
        }
    }
}
