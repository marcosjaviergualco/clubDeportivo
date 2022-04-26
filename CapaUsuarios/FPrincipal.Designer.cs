
namespace CapaUsuarios
{
    partial class FPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnModificarActividad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnListarActividades = new System.Windows.Forms.Button();
            this.btnEliminarActividad = new System.Windows.Forms.Button();
            this.btnCrearActividad = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnListarPagos = new System.Windows.Forms.Button();
            this.btnGenerarPago = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnListarSocios = new System.Windows.Forms.Button();
            this.btnEliminarSocio = new System.Windows.Forms.Button();
            this.btnCrearSocio = new System.Windows.Forms.Button();
            this.btnCrearProfesor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModificarActividad);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnListarActividades);
            this.groupBox1.Controls.Add(this.btnEliminarActividad);
            this.groupBox1.Controls.Add(this.btnCrearActividad);
            this.groupBox1.Location = new System.Drawing.Point(575, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACTIVIDADES";
            // 
            // btnModificarActividad
            // 
            this.btnModificarActividad.Location = new System.Drawing.Point(38, 283);
            this.btnModificarActividad.Name = "btnModificarActividad";
            this.btnModificarActividad.Size = new System.Drawing.Size(117, 40);
            this.btnModificarActividad.TabIndex = 4;
            this.btnModificarActividad.Text = "MODIFICAR ACTIVIDAD";
            this.btnModificarActividad.UseVisualStyleBackColor = true;
            this.btnModificarActividad.Click += new System.EventHandler(this.btnModificarActividad_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "INSCRIBIR SOCIO A ACTIVIDAD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListarActividades
            // 
            this.btnListarActividades.Location = new System.Drawing.Point(40, 155);
            this.btnListarActividades.Name = "btnListarActividades";
            this.btnListarActividades.Size = new System.Drawing.Size(115, 35);
            this.btnListarActividades.TabIndex = 2;
            this.btnListarActividades.Text = "LISTAR ACTIVIDADES";
            this.btnListarActividades.UseVisualStyleBackColor = true;
            this.btnListarActividades.Click += new System.EventHandler(this.btnListarActividades_Click);
            // 
            // btnEliminarActividad
            // 
            this.btnEliminarActividad.Location = new System.Drawing.Point(40, 86);
            this.btnEliminarActividad.Name = "btnEliminarActividad";
            this.btnEliminarActividad.Size = new System.Drawing.Size(115, 38);
            this.btnEliminarActividad.TabIndex = 1;
            this.btnEliminarActividad.Text = "ELIMINAR ACTIVIDAD";
            this.btnEliminarActividad.UseVisualStyleBackColor = true;
            this.btnEliminarActividad.Click += new System.EventHandler(this.btnEliminarActividad_Click);
            // 
            // btnCrearActividad
            // 
            this.btnCrearActividad.Location = new System.Drawing.Point(40, 33);
            this.btnCrearActividad.Name = "btnCrearActividad";
            this.btnCrearActividad.Size = new System.Drawing.Size(115, 23);
            this.btnCrearActividad.TabIndex = 0;
            this.btnCrearActividad.Text = "CREAR ACTIVIDAD";
            this.btnCrearActividad.UseVisualStyleBackColor = true;
            this.btnCrearActividad.Click += new System.EventHandler(this.btnCrearActividad_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnListarPagos);
            this.groupBox2.Controls.Add(this.btnGenerarPago);
            this.groupBox2.Location = new System.Drawing.Point(304, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PAGOS";
            // 
            // btnListarPagos
            // 
            this.btnListarPagos.Location = new System.Drawing.Point(61, 145);
            this.btnListarPagos.Name = "btnListarPagos";
            this.btnListarPagos.Size = new System.Drawing.Size(75, 23);
            this.btnListarPagos.TabIndex = 1;
            this.btnListarPagos.Text = "LISTAR PAGOS";
            this.btnListarPagos.UseVisualStyleBackColor = true;
            this.btnListarPagos.Click += new System.EventHandler(this.btnListarPagos_Click);
            // 
            // btnGenerarPago
            // 
            this.btnGenerarPago.Location = new System.Drawing.Point(61, 72);
            this.btnGenerarPago.Name = "btnGenerarPago";
            this.btnGenerarPago.Size = new System.Drawing.Size(74, 36);
            this.btnGenerarPago.TabIndex = 0;
            this.btnGenerarPago.Text = "GENERAR PAGO";
            this.btnGenerarPago.UseVisualStyleBackColor = true;
            this.btnGenerarPago.Click += new System.EventHandler(this.btnGenerarPago_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnListarSocios);
            this.groupBox3.Controls.Add(this.btnEliminarSocio);
            this.groupBox3.Controls.Add(this.btnCrearSocio);
            this.groupBox3.Location = new System.Drawing.Point(42, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 284);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SOCIOS";
            // 
            // btnListarSocios
            // 
            this.btnListarSocios.Location = new System.Drawing.Point(45, 222);
            this.btnListarSocios.Name = "btnListarSocios";
            this.btnListarSocios.Size = new System.Drawing.Size(106, 23);
            this.btnListarSocios.TabIndex = 2;
            this.btnListarSocios.Text = "LISTAR SOCIOS";
            this.btnListarSocios.UseVisualStyleBackColor = true;
            this.btnListarSocios.Click += new System.EventHandler(this.btnListarSocios_Click);
            // 
            // btnEliminarSocio
            // 
            this.btnEliminarSocio.Location = new System.Drawing.Point(45, 145);
            this.btnEliminarSocio.Name = "btnEliminarSocio";
            this.btnEliminarSocio.Size = new System.Drawing.Size(106, 23);
            this.btnEliminarSocio.TabIndex = 1;
            this.btnEliminarSocio.Text = "ELIMINAR SOCIO";
            this.btnEliminarSocio.UseVisualStyleBackColor = true;
            this.btnEliminarSocio.Click += new System.EventHandler(this.btnEliminarSocio_Click);
            // 
            // btnCrearSocio
            // 
            this.btnCrearSocio.Location = new System.Drawing.Point(45, 72);
            this.btnCrearSocio.Name = "btnCrearSocio";
            this.btnCrearSocio.Size = new System.Drawing.Size(106, 23);
            this.btnCrearSocio.TabIndex = 0;
            this.btnCrearSocio.Text = "CREAR SOCIO";
            this.btnCrearSocio.UseVisualStyleBackColor = true;
            this.btnCrearSocio.Click += new System.EventHandler(this.btnCrearSocio_Click);
            // 
            // btnCrearProfesor
            // 
            this.btnCrearProfesor.Location = new System.Drawing.Point(42, 382);
            this.btnCrearProfesor.Name = "btnCrearProfesor";
            this.btnCrearProfesor.Size = new System.Drawing.Size(130, 23);
            this.btnCrearProfesor.TabIndex = 3;
            this.btnCrearProfesor.Text = "CREAR PROFESOR";
            this.btnCrearProfesor.UseVisualStyleBackColor = true;
            this.btnCrearProfesor.Click += new System.EventHandler(this.btnCrearProfesor_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "BORRAR SOCIO DE ACTIVIDAD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCrearProfesor);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FPrincipal";
            this.Text = "PRINCIPAL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FPrincipal_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminarActividad;
        private System.Windows.Forms.Button btnCrearActividad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGenerarPago;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminarSocio;
        private System.Windows.Forms.Button btnCrearSocio;
        private System.Windows.Forms.Button btnListarActividades;
        private System.Windows.Forms.Button btnListarPagos;
        private System.Windows.Forms.Button btnListarSocios;
        private System.Windows.Forms.Button btnCrearProfesor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModificarActividad;
        private System.Windows.Forms.Button button2;
    }
}

