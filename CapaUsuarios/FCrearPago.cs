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

        private Pago pago;

        public FCrearPago(List<Pago> pagos, List<Socio> socios)
        {
            InitializeComponent();
            comboBoxSocio.DataSource = socios;
            this.pagos = pagos;

        }

        private void btnEfectuarPago_Click(object sender, EventArgs e)
        {
            unSocio = (Socio)comboBoxSocio.SelectedItem;
            DateTime unaFecha = dateTimePickerPago.Value;
            int unId;


            if (pagos.Count == 0)
                unId = 1000;
            else
            {
                unId = pagos.Last().Id + 1;
            }



            pago = new Pago(unId, unSocio.devolverCosto(), unSocio);

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
    }
}
