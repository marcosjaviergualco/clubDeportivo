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
        string lugarBase;

        public FPrincipal()
        {
            InitializeComponent();
           // cl = Club.Recuperar();
            cl.PonerPathABaseAccess(lugarBase);
            cl = new Club();
          
        }


        private void btnCrearSocio_Click(object sender, EventArgs e)
        {
            FCrearSocio fc = new FCrearSocio();
            fc.ShowDialog();
            Socio socio = fc.Socio;
            if (socio != null) {
                cl.agregar(socio);
                MessageBox.Show("SOCIO CREADO CON EXITO");
            }
    }

        private void btnCrearActividad_Click(object sender, EventArgs e)
        {
            FCrearActividad fca = new FCrearActividad(cl.Profesores);
            fca.ShowDialog();
            // Agregar a lista de actividades
            Actividad a = fca.Actividad;
            if (a != null)
            {
                cl.agregar(a);
                MessageBox.Show("ACTIVIDAD CREADA SATISFACTORIAMENTE");
            }
        }

        private void btnCrearProfesor_Click(object sender, EventArgs e)
        {
            FCrearProfesor fcp = new FCrearProfesor();
            fcp.ShowDialog();
            // Agregar a lista de profesores
            Profesor p = fcp.Prof;
            if (p != null) {
                cl.agregar(p);
                MessageBox.Show("PROFESOR CREADO CON EXITO");
            }
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

        private void btnGenerarPago_Click(object sender, EventArgs e)
        {
            FCrearPago fcp = new FCrearPago(cl.Socios);
            fcp.ShowDialog();
            cl.generarPago(fcp.Socio, fcp.Fecha);
            MessageBox.Show("PAGO GENERADO CORRECTAMENTE");

        }

        // button1 es btnInscribirSocio
        private void button1_Click(object sender, EventArgs e)
        {
            FInscribir fi = new FInscribir(cl.Actividades, cl.Socios);
            fi.ShowDialog();
        }

        private void btnModificarActividad_Click(object sender, EventArgs e)
        {
            FModificarActividad fmi = new FModificarActividad(cl.Actividades, cl.Profesores);
            fmi.ShowDialog();
        }

        private void btnListarSocios_Click(object sender, EventArgs e)
        {
                FMostrarSocios fms = new FMostrarSocios(cl.Socios);
                fms.ShowDialog();
        }

        // button2 es btnBorrarSocioDeActividad
        private void button2_Click(object sender, EventArgs e)
        {
            FBorrarSocioDeActividad fbs = new FBorrarSocioDeActividad(cl.Socios);
            fbs.ShowDialog();
        }

        private void btnEliminarActividad_Click(object sender, EventArgs e)
        {
            FEliminarActividad fea = new FEliminarActividad(cl.Actividades);
            fea.ShowDialog();

            cl.removerSocioActividad(fea.Actividad);
            cl.removerActividad(fea.Actividad);
            MessageBox.Show("ACTIVIDAD BORRADA CON EXITO");

        }

        private void btnEliminarSocio_Click(object sender, EventArgs e)
        {
            FBorrarSocio fbs = new FBorrarSocio(cl.Socios);
            fbs.ShowDialog();
            cl.Socios = fbs.Socios;
        }

        private void btnListarPagos_Click(object sender, EventArgs e)
        {
            FMostrarPagos fmp = new FMostrarPagos(cl.Pago);
            fmp.ShowDialog();
        }

        // button3 es listar profesores
        private void button3_Click(object sender, EventArgs e)
        {
            FMostrarProfesor fmprof = new FMostrarProfesor(cl.Profesores);

            fmprof.ShowDialog();

            cl.removerProfesor(fmprof.Profesor);
        }
    }
}
