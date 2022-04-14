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
    public partial class FCrearSocio : Form
    {
        private FCrearSocio soc;
        public FCrearSocio()
        {
            InitializeComponent();
            soc = null;
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
            string tipoDeSocio = this.comboBoxTipoSocio.Text;
            Socio soc;
            if (tipoDeSocio == "Socio Club")
            {
               float unaCuotaSocial = float.Parse(this.textBoxCuotaSocial.Text);
               soc = new SocioClub(unDni, unNom, g, fn, unDom, unaCuotaSocial);
            }
            else
            {
                soc = new SocioActividad(unDni, unNom, g, fn, unDom);
            }    
            
            

        }

        private void comboBoxTipoSocio_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoSocio.SelectedIndex==0)
            {
                labelCuotaSocial.Visible = true;
                textBoxCuotaSocial.Visible=true;
            }
            else
            {
                labelCuotaSocial.Visible = false;
                textBoxCuotaSocial.Visible = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
