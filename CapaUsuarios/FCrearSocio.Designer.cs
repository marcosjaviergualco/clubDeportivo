
namespace CapaUsuarios
{
    partial class FCrearSocio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textNombreCompleto = new System.Windows.Forms.TextBox();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.dateTimeFechaNac = new System.Windows.Forms.DateTimePicker();
            this.textDomicilio = new System.Windows.Forms.TextBox();
            this.maskedTextDni = new System.Windows.Forms.MaskedTextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.comboBoxTipoSocio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCuotaSocial = new System.Windows.Forms.TextBox();
            this.labelCuotaSocial = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre y Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Domicilio";
            // 
            // textNombreCompleto
            // 
            this.textNombreCompleto.Location = new System.Drawing.Point(48, 52);
            this.textNombreCompleto.Name = "textNombreCompleto";
            this.textNombreCompleto.Size = new System.Drawing.Size(257, 20);
            this.textNombreCompleto.TabIndex = 5;
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
            // dateTimeFechaNac
            // 
            this.dateTimeFechaNac.Location = new System.Drawing.Point(49, 212);
            this.dateTimeFechaNac.Name = "dateTimeFechaNac";
            this.dateTimeFechaNac.Size = new System.Drawing.Size(256, 20);
            this.dateTimeFechaNac.TabIndex = 9;
            // 
            // textDomicilio
            // 
            this.textDomicilio.Location = new System.Drawing.Point(48, 282);
            this.textDomicilio.Name = "textDomicilio";
            this.textDomicilio.Size = new System.Drawing.Size(257, 20);
            this.textDomicilio.TabIndex = 10;
            // 
            // maskedTextDni
            // 
            this.maskedTextDni.Location = new System.Drawing.Point(48, 103);
            this.maskedTextDni.Mask = "00.000.000";
            this.maskedTextDni.Name = "maskedTextDni";
            this.maskedTextDni.Size = new System.Drawing.Size(80, 20);
            this.maskedTextDni.TabIndex = 11;
            this.maskedTextDni.ValidatingType = typeof(int);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(351, 355);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(103, 23);
            this.btnCrear.TabIndex = 12;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(510, 354);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // comboBoxTipoSocio
            // 
            this.comboBoxTipoSocio.FormattingEnabled = true;
            this.comboBoxTipoSocio.Items.AddRange(new object[] {
            "Socio Club",
            "Socio Actividad"});
            this.comboBoxTipoSocio.Location = new System.Drawing.Point(406, 52);
            this.comboBoxTipoSocio.Name = "comboBoxTipoSocio";
            this.comboBoxTipoSocio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoSocio.TabIndex = 14;
            this.comboBoxTipoSocio.SelectedValueChanged += new System.EventHandler(this.comboBoxTipoSocio_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tipo de Socio";
            // 
            // textBoxCuotaSocial
            // 
            this.textBoxCuotaSocial.Location = new System.Drawing.Point(406, 102);
            this.textBoxCuotaSocial.Name = "textBoxCuotaSocial";
            this.textBoxCuotaSocial.Size = new System.Drawing.Size(121, 20);
            this.textBoxCuotaSocial.TabIndex = 16;
            // 
            // labelCuotaSocial
            // 
            this.labelCuotaSocial.AutoSize = true;
            this.labelCuotaSocial.Location = new System.Drawing.Point(406, 86);
            this.labelCuotaSocial.Name = "labelCuotaSocial";
            this.labelCuotaSocial.Size = new System.Drawing.Size(67, 13);
            this.labelCuotaSocial.TabIndex = 17;
            this.labelCuotaSocial.Text = "Cuota Social";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioF);
            this.groupBox1.Controls.Add(this.radioM);
            this.groupBox1.Location = new System.Drawing.Point(48, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 41);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genero";
            // 
            // FCrearSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelCuotaSocial);
            this.Controls.Add(this.textBoxCuotaSocial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxTipoSocio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.maskedTextDni);
            this.Controls.Add(this.textDomicilio);
            this.Controls.Add(this.dateTimeFechaNac);
            this.Controls.Add(this.textNombreCompleto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FCrearSocio";
            this.Text = "FCrearSocio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNombreCompleto;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.DateTimePicker dateTimeFechaNac;
        private System.Windows.Forms.TextBox textDomicilio;
        private System.Windows.Forms.MaskedTextBox maskedTextDni;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox comboBoxTipoSocio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCuotaSocial;
        private System.Windows.Forms.Label labelCuotaSocial;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}