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
    public partial class FMostrarProfesor : Form
    {
        Profesor p;
        Club club;
        public FMostrarProfesor(List<Profesor> profesores, Club club)
        {
            InitializeComponent();
            listBox1.DataSource = profesores;
            this.club = club;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
                listBox2.DataSource = ((Profesor)(listBox1.SelectedItem)).ActividadesAsociadas;
        }

        private void btnBorrarProfe_Click(object sender, EventArgs e)
        {
            p = (Profesor)listBox1.SelectedItem;
            List<Actividad> actividades = ((Profesor)listBox1.SelectedItem).Actividades;

            foreach (var item in actividades)
            {
                item.removerProfe();
                this.club.modificar(item); // llama a modificar despues de que remover al profe de la actividad en memoria
            }

            this.club.removerProfesor(p);

            this.Close();
        }

        public Profesor Profesor
        {
            get { return p; }
        }

        private void btnDeseleccionar_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
        }
    }
}
