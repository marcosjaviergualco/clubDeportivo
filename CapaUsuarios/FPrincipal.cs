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
    public partial class FPrincipal : Form
    {
        private Club cl;
        private List<Actividad> actividades;
        private List<Socio> socios;
        private List<Pago> pagos;

        public FPrincipal()
        {
            InitializeComponent();
            cl = new Club();
        }

        private void btnCrearSocio_Click(object sender, EventArgs e)
        {
            FCrearSocio fc = new FCrearSocio();
            fc.ShowDialog();
            //No comprendo cómo es que se debe agregar un nuevo socio desde el formulario principal
            //Socio socio = fc.
        }

        
    }
}
