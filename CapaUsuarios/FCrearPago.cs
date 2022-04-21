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

        public FCrearPago(List<Actividad> actividades, List<Socio> socios)
        {
            InitializeComponent();
            comboBoxActividad.DataSource = actividades;
            comboBoxSocio.DataSource = socios;

        }

        private void btnEfectuarPago_Click(object sender, EventArgs e)
        {
            unaActividad = (Actividad)comboBoxActividad.SelectedItem;
            unSocio = (Socio)comboBoxSocio.SelectedItem;
            unaFecha = dateTimePickerPago.Value;


        }
    }
}
