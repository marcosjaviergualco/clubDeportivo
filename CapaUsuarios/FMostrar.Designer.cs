
namespace CapaUsuarios
{
    partial class FMostrar
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
            this.listBoxMostrar = new System.Windows.Forms.ListBox();
            this.btnCerrarMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMostrar
            // 
            this.listBoxMostrar.FormattingEnabled = true;
            this.listBoxMostrar.Location = new System.Drawing.Point(12, 12);
            this.listBoxMostrar.Name = "listBoxMostrar";
            this.listBoxMostrar.Size = new System.Drawing.Size(776, 381);
            this.listBoxMostrar.TabIndex = 0;
            // 
            // btnCerrarMostrar
            // 
            this.btnCerrarMostrar.Location = new System.Drawing.Point(603, 413);
            this.btnCerrarMostrar.Name = "btnCerrarMostrar";
            this.btnCerrarMostrar.Size = new System.Drawing.Size(185, 23);
            this.btnCerrarMostrar.TabIndex = 1;
            this.btnCerrarMostrar.Text = "Cerrar";
            this.btnCerrarMostrar.UseVisualStyleBackColor = true;
            this.btnCerrarMostrar.Click += new System.EventHandler(this.btnCerrarMostrar_Click);
            // 
            // FMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrarMostrar);
            this.Controls.Add(this.listBoxMostrar);
            this.Name = "FMostrar";
            this.Text = "FMostrar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMostrar;
        private System.Windows.Forms.Button btnCerrarMostrar;
    }
}