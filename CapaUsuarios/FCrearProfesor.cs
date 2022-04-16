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
    public partial class FCrearProfesor : Form
    {
        private Profesor prof;
        public FCrearProfesor()
        {
            InitializeComponent();
            prof = null;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string unDni = this.maskedTextDni.Text;
            string unNom = this.textNombreCompleto.Text;
            DateTime fn = this.dateTimeFechaNac.Value;
            char g;
            if (this.radioF.Checked)
                g = 'F';
            else
                g = 'M';
            string unDom = this.textDomicilio.Text;
            string unLeg = this.textBoxLegajo.Text;

            prof = new Profesor(unDni, unNom, g, fn, unDom, unLeg);

            

            this.Close();
        }

        public Profesor Prof
        {
            get { return prof;} 
        }
    }
}
