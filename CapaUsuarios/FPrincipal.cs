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
        /*private List<Actividad> actividades;
        private List<Socio> socios;
        private List<Pago> pagos;
        private List<Profesor> profesores;
        */

        public FPrincipal()
        {
            InitializeComponent();
            cl = Club.Recuperar();
        }

        private void btnCrearSocio_Click(object sender, EventArgs e)
        {
            FCrearSocio fc = new FCrearSocio();
            fc.ShowDialog();
            Socio socio = fc.Socio;
            cl.Socios.Add(socio);
        }

        private void btnCrearActividad_Click(object sender, EventArgs e)
        {
            FCrearActividad fca = new FCrearActividad(cl.Profesores);
            fca.ShowDialog();
            // Agregar a lista de actividades
            Actividad a = fca.Actividad;
            cl.Actividades.Add(a);
        }

        private void btnCrearProfesor_Click(object sender, EventArgs e)
        {
            FCrearProfesor fcp = new FCrearProfesor();
            fcp.ShowDialog();
            // Agregar a lista de profesores
            Profesor p = fcp.Prof;
            cl.Profesores.Add(p);
        }

        private void btnListarActividades_Click(object sender, EventArgs e)
        {
            FMostrar fm = new FMostrar(cl.Actividades);
            fm.ShowDialog();
        }

        private void FPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cl.Guardar())
                MessageBox.Show("GUARDADO OK");
            else
                MessageBox.Show("ERROR AL GUARDAR");
        }
    }
}
