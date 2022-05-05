﻿using System;
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
    public partial class FMostrarPagos : Form
    {
        public FMostrarPagos(List<Pago> pagos)
        {
            InitializeComponent();
            listBoxMostrarPagos.DataSource = pagos;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}