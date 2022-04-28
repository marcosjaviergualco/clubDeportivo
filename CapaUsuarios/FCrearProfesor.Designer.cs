
namespace CapaUsuarios
{
    partial class FCrearProfesor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.maskedTextDni = new System.Windows.Forms.MaskedTextBox();
            this.textDomicilio = new System.Windows.Forms.TextBox();
            this.dateTimeFechaNac = new System.Windows.Forms.DateTimePicker();
            this.textNombreCompleto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labelLegajo = new System.Windows.Forms.Label();
            this.textBoxLegajo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioF);
            this.groupBox1.Controls.Add(this.radioM);
            this.groupBox1.Location = new System.Drawing.Point(48, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 41);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genero";
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Checked = true;
            this.radioF.Location = new System.Drawing.Point(6, 17);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(31, 17);
            this.radioF.TabIndex = 7;
            this.radioF.TabStop = true;
            this.radioF.Text = "F";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Location = new System.Drawing.Point(60, 17);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(34, 17);
            this.radioM.TabIndex = 8;
            this.radioM.Text = "M";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // maskedTextDni
            // 
            this.maskedTextDni.Location = new System.Drawing.Point(48, 109);
            this.maskedTextDni.Mask = "00.000.000";
            this.maskedTextDni.Name = "maskedTextDni";
            this.maskedTextDni.Size = new System.Drawing.Size(80, 20);
            this.maskedTextDni.TabIndex = 26;
            this.maskedTextDni.ValidatingType = typeof(int);
            // 
            // textDomicilio
            // 
            this.textDomicilio.Location = new System.Drawing.Point(48, 288);
            this.textDomicilio.Name = "textDomicilio";
            this.textDomicilio.Size = new System.Drawing.Size(257, 20);
            this.textDomicilio.TabIndex = 25;
            // 
            // dateTimeFechaNac
            // 
            this.dateTimeFechaNac.Location = new System.Drawing.Point(49, 218);
            this.dateTimeFechaNac.Name = "dateTimeFechaNac";
            this.dateTimeFechaNac.Size = new System.Drawing.Size(256, 20);
            this.dateTimeFechaNac.TabIndex = 24;
            // 
            // textNombreCompleto
            // 
            this.textNombreCompleto.Location = new System.Drawing.Point(48, 58);
            this.textNombreCompleto.Name = "textNombreCompleto";
            this.textNombreCompleto.Size = new System.Drawing.Size(257, 20);
            this.textNombreCompleto.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Domicilio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre y Apellido";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(490, 392);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(110, 23);
            this.btnCrear.TabIndex = 28;
            this.btnCrear.Text = "Crear Profesor";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(652, 392);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelLegajo
            // 
            this.labelLegajo.AutoSize = true;
            this.labelLegajo.Location = new System.Drawing.Point(51, 330);
            this.labelLegajo.Name = "labelLegajo";
            this.labelLegajo.Size = new System.Drawing.Size(39, 13);
            this.labelLegajo.TabIndex = 30;
            this.labelLegajo.Text = "Legajo";
            // 
            // textBoxLegajo
            // 
            this.textBoxLegajo.Location = new System.Drawing.Point(48, 358);
            this.textBoxLegajo.Name = "textBoxLegajo";
            this.textBoxLegajo.Size = new System.Drawing.Size(257, 20);
            this.textBoxLegajo.TabIndex = 31;
            // 
            // FCrearProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxLegajo);
            this.Controls.Add(this.labelLegajo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.maskedTextDni);
            this.Controls.Add(this.textDomicilio);
            this.Controls.Add(this.dateTimeFechaNac);
            this.Controls.Add(this.textNombreCompleto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FCrearProfesor";
            this.Text = "FCrearProfesor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.MaskedTextBox maskedTextDni;
        private System.Windows.Forms.TextBox textDomicilio;
        private System.Windows.Forms.DateTimePicker dateTimeFechaNac;
        private System.Windows.Forms.TextBox textNombreCompleto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labelLegajo;
        private System.Windows.Forms.TextBox textBoxLegajo;
    }
}