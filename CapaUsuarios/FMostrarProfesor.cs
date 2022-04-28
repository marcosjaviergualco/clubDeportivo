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
        public FMostrarProfesor(List<Profesor> profesores)
        {
            InitializeComponent();
            listBox1.DataSource = profesores;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
