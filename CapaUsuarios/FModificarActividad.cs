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
    public partial class FModificarActividad : Form
    {
        public FModificarActividad(List<Actividad> actividades, List<Profesor> profesores)
        {
            InitializeComponent();
            comboBoxActividades.DataSource = actividades;
            comboBoxProfesores.DataSource = profesores;
            comboBoxActividades.SelectedItem = comboBoxActividades.Items.Count - 1;
        }

        private void comboBoxActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxId.Text = ((Actividad)comboBoxActividades.SelectedItem).Id.ToString();
            textBoxDesc.Text = ((Actividad)comboBoxActividades.SelectedItem).Descripcion.ToString();
            textBoxCantMax.Text = ((Actividad)comboBoxActividades.SelectedItem).CantMaxParticipantes.ToString();
            textBoxCosto.Text = ((Actividad)comboBoxActividades.SelectedItem).Costo.ToString();
            dateTimePickerHora.Value = ((Actividad)comboBoxActividades.SelectedItem).Hora;
            comboBoxDia.SelectedItem = ((Actividad)comboBoxActividades.SelectedItem).Dia;
            if (((Actividad)comboBoxActividades.SelectedItem).Profesor != null)
                comboBoxProfesores.Text = ((Actividad)comboBoxActividades.SelectedItem).Profesor.ToString();
            else
                comboBoxProfesores.Text = "";

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                ((Actividad)comboBoxActividades.SelectedItem).Descripcion = textBoxDesc.Text;
                ((Actividad)comboBoxActividades.SelectedItem).Dia = comboBoxDia.SelectedItem.ToString();
                ((Actividad)comboBoxActividades.SelectedItem).Hora = dateTimePickerHora.Value;
                ((Actividad)comboBoxActividades.SelectedItem).Costo = float.Parse(this.textBoxCosto.Text);
                ((Actividad)comboBoxActividades.SelectedItem).CantMaxParticipantes = int.Parse(this.textBoxCantMax.Text);
                ((Actividad)comboBoxActividades.SelectedItem).Profesor = (Profesor)comboBoxProfesores.SelectedItem;
                if (((Actividad)comboBoxActividades.SelectedItem).Profesor != null)
                    ((Actividad)comboBoxActividades.SelectedItem).Profesor.agregate((Actividad)comboBoxActividades.SelectedItem);

                if (textBoxDesc.Text.Length == 0)
                {
                    throw new DescripcionException();
                    textBoxDesc.Focus();
                }
                if (textBoxCosto.Text.Length == 0)
                {
                    throw new CostoException();
                    textBoxCosto.Focus();
                }
                this.Close();
            }
            catch (DescripcionException ex)
            {
                MessageBox.Show(ex.Message);
                textBoxDesc.Focus();
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
