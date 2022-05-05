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
    public partial class FBorrarSocioDeActividad : Form
    {
        public FBorrarSocioDeActividad(List<Socio> socios)
        {
            InitializeComponent();
            comboBoxSocios.DataSource = socios;
        }

        private void comboBoxSocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxActividades.DataSource = ((Socio)comboBoxSocios.SelectedItem).Actividades;
            listBoxActividades.ClearSelected();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ((Actividad)listBoxActividades.SelectedItem).removerSocio((Socio)comboBoxSocios.SelectedItem);

            ((Socio)comboBoxSocios.SelectedItem).removerActividad((Actividad)listBoxActividades.SelectedItem);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}