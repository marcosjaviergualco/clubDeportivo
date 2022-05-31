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
    public partial class FCrearPago : Form
    {
        private Actividad unaActividad;
        private Socio unSocio;
        private DateTime unaFecha;
        private float unMonto;
        private List<Pago> pagos;
        private int id;

        private Pago pago;

        public FCrearPago(List<Socio> socios)
        {
            InitializeComponent();
            comboBoxSocio.DataSource = socios;

        }

        private void btnEfectuarPago_Click(object sender, EventArgs e)
        {
            unSocio = (Socio)comboBoxSocio.SelectedItem;
            unaFecha = dateTimePickerPago.Value;
            
            this.Close();
        }

        private void comboBoxSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "$ "+((Socio)comboBoxSocio.SelectedItem).devolverCosto().ToString();
        }

        public Pago Pago
        {
            get { return pago; }
        }

        public Socio Socio
        {
            get { return unSocio; }
        }

        public DateTime Fecha
        {
            get { return unaFecha; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
