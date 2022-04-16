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
using Excepciones;

namespace CapaUsuarios
{
    public partial class FCrearSocio : Form
    {
        private Socio soc;
        public FCrearSocio()
        {
            InitializeComponent();
            soc = null;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
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

                    if (unaCuotaSocial == 0)
                    {
                        throw new CostoException();
                    }
                }
                else
                {
                    soc = new SocioActividad(unDni, unNom, g, fn, unDom);
                }
                string format1Dni = unDni.Replace(" ", "");
                string format2Dni = format1Dni.Replace(",", "");
                if (format2Dni.Length == 0)
                    throw new DniException();

                if( unNom.Length == 0)
                    throw new NombreException();

                if (unDom.Length == 0)
                {
                    throw new DomicilioException();
                    textDomicilio.Focus();
                }


                this.Close();
            }
            catch (NombreException ex)
            {
                MessageBox.Show(ex.Message);
                textNombreCompleto.Focus();
            }
            catch (DniException ex)
            {
                MessageBox.Show(ex.Message);
                maskedTextDni.Focus();
            }
            catch (DomicilioException ex)
            {
                MessageBox.Show(ex.Message);
                maskedTextDni.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        public Socio Socio
        {
            get { return soc; }
        }
    }
}
