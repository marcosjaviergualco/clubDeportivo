
namespace CapaUsuarios
{
    partial class FCrearPago
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
            this.dateTimePickerPago = new System.Windows.Forms.DateTimePicker();
            this.gbCrearPago = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSocio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEfectuarPago = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbCrearPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerPago
            // 
            this.dateTimePickerPago.Location = new System.Drawing.Point(39, 50);
            this.dateTimePickerPago.Name = "dateTimePickerPago";
            this.dateTimePickerPago.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerPago.TabIndex = 0;
            // 
            // gbCrearPago
            // 
            this.gbCrearPago.Controls.Add(this.textBox1);
            this.gbCrearPago.Controls.Add(this.label4);
            this.gbCrearPago.Controls.Add(this.label3);
            this.gbCrearPago.Controls.Add(this.comboBoxSocio);
            this.gbCrearPago.Controls.Add(this.label1);
            this.gbCrearPago.Controls.Add(this.dateTimePickerPago);
            this.gbCrearPago.Location = new System.Drawing.Point(43, 55);
            this.gbCrearPago.Name = "gbCrearPago";
            this.gbCrearPago.Size = new System.Drawing.Size(625, 288);
            this.gbCrearPago.TabIndex = 1;
            this.gbCrearPago.TabStop = false;
            this.gbCrearPago.Text = "Alta de nuevo pago";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(491, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Socio";
            // 
            // comboBoxSocio
            // 
            this.comboBoxSocio.FormattingEnabled = true;
            this.comboBoxSocio.Location = new System.Drawing.Point(39, 123);
            this.comboBoxSocio.Name = "comboBoxSocio";
            this.comboBoxSocio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSocio.TabIndex = 3;
            this.comboBoxSocio.SelectedIndexChanged += new System.EventHandler(this.comboBoxSocio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de pago";
            // 
            // btnEfectuarPago
            // 
            this.btnEfectuarPago.Location = new System.Drawing.Point(491, 387);
            this.btnEfectuarPago.Name = "btnEfectuarPago";
            this.btnEfectuarPago.Size = new System.Drawing.Size(109, 29);
            this.btnEfectuarPago.TabIndex = 2;
            this.btnEfectuarPago.Text = "Efectuar pago";
            this.btnEfectuarPago.UseVisualStyleBackColor = true;
            this.btnEfectuarPago.Click += new System.EventHandler(this.btnEfectuarPago_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(639, 387);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 29);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FCrearPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEfectuarPago);
            this.Controls.Add(this.gbCrearPago);
            this.Name = "FCrearPago";
            this.Text = "FCrearPago";
            this.gbCrearPago.ResumeLayout(false);
            this.gbCrearPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerPago;
        private System.Windows.Forms.GroupBox gbCrearPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSocio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEfectuarPago;
        private System.Windows.Forms.Button btnCancelar;
    }
}