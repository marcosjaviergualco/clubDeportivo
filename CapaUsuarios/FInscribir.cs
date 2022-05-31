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
    public partial class FInscribir : Form
    {
        Club club;
        private Socio s;
        private Actividad a;
        public FInscribir(List<Actividad> actividades, List<Socio> socios, Club club)
        {
            InitializeComponent();
            comboBoxActividades.DataSource = actividades;
            comboBoxSocios.DataSource = socios;
            this.club = club;
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            try
            {
                Actividad actividad = (Actividad)comboBoxActividades.SelectedItem;

                if (actividad.Socios.Count() == actividad.CantMaxParticipantes)
                    throw new CantidadMaximaException();

                s = (Socio)comboBoxSocios.SelectedItem;
                s.inscribir((Actividad)comboBoxActividades.SelectedItem);

                ((Actividad)comboBoxActividades.SelectedItem).agregar(s);

                bool status = club.inscribir((Actividad)comboBoxActividades.SelectedItem, (Socio)comboBoxSocios.SelectedItem);
                if (status)
                {
                    MessageBox.Show("SOCIO INSCRITO SATISFACTORIAMENTE");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
