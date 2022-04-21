
namespace CapaUsuarios
{
    partial class FInscribir
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
            this.comboBoxSocios = new System.Windows.Forms.ComboBox();
            this.comboBoxActividades = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSocios
            // 
            this.comboBoxSocios.FormattingEnabled = true;
            this.comboBoxSocios.Location = new System.Drawing.Point(39, 87);
            this.comboBoxSocios.Name = "comboBoxSocios";
            this.comboBoxSocios.Size = new System.Drawing.Size(217, 21);
            this.comboBoxSocios.TabIndex = 0;
            // 
            // comboBoxActividades
            // 
            this.comboBoxActividades.FormattingEnabled = true;
            this.comboBoxActividades.Location = new System.Drawing.Point(340, 87);
            this.comboBoxActividades.Name = "comboBoxActividades";
            this.comboBoxActividades.Size = new System.Drawing.Size(206, 21);
            this.comboBoxActividades.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Socios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Actividades";
            // 
            // btnInscribir
            // 
            this.btnInscribir.Location = new System.Drawing.Point(516, 375);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(75, 23);
            this.btnInscribir.TabIndex = 4;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(624, 375);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FInscribir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxActividades);
            this.Controls.Add(this.comboBoxSocios);
            this.Name = "FInscribir";
            this.Text = "FInscribir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSocios;
        private System.Windows.Forms.ComboBox comboBoxActividades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnCancelar;
    }
}