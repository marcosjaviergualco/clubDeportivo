
namespace CapaUsuarios
{
    partial class FCrearActividad
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
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelProfesor = new System.Windows.Forms.Label();
            this.listBoxProfesores = new System.Windows.Forms.ListBox();
            this.labelCosto = new System.Windows.Forms.Label();
            this.labelCantMax = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxCosto = new System.Windows.Forms.TextBox();
            this.textBoxCantMax = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dateTimePickerHora = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(72, 88);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 0;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(72, 36);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hora";
            // 
            // labelProfesor
            // 
            this.labelProfesor.AutoSize = true;
            this.labelProfesor.Location = new System.Drawing.Point(342, 36);
            this.labelProfesor.Name = "labelProfesor";
            this.labelProfesor.Size = new System.Drawing.Size(46, 13);
            this.labelProfesor.TabIndex = 3;
            this.labelProfesor.Text = "Profesor";
            // 
            // listBoxProfesores
            // 
            this.listBoxProfesores.FormattingEnabled = true;
            this.listBoxProfesores.Location = new System.Drawing.Point(345, 52);
            this.listBoxProfesores.Name = "listBoxProfesores";
            this.listBoxProfesores.Size = new System.Drawing.Size(119, 186);
            this.listBoxProfesores.TabIndex = 4;
            // 
            // labelCosto
            // 
            this.labelCosto.AutoSize = true;
            this.labelCosto.Location = new System.Drawing.Point(73, 283);
            this.labelCosto.Name = "labelCosto";
            this.labelCosto.Size = new System.Drawing.Size(34, 13);
            this.labelCosto.TabIndex = 5;
            this.labelCosto.Text = "Costo";
            // 
            // labelCantMax
            // 
            this.labelCantMax.AutoSize = true;
            this.labelCantMax.Location = new System.Drawing.Point(72, 224);
            this.labelCantMax.Name = "labelCantMax";
            this.labelCantMax.Size = new System.Drawing.Size(167, 13);
            this.labelCantMax.TabIndex = 6;
            this.labelCantMax.Text = "Cantidad Máxima de Participantes";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(75, 52);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 7;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(75, 104);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(100, 20);
            this.textBoxDesc.TabIndex = 8;
            // 
            // textBoxCosto
            // 
            this.textBoxCosto.Location = new System.Drawing.Point(75, 300);
            this.textBoxCosto.Name = "textBoxCosto";
            this.textBoxCosto.Size = new System.Drawing.Size(100, 20);
            this.textBoxCosto.TabIndex = 10;
            // 
            // textBoxCantMax
            // 
            this.textBoxCantMax.Location = new System.Drawing.Point(75, 240);
            this.textBoxCantMax.Name = "textBoxCantMax";
            this.textBoxCantMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantMax.TabIndex = 11;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(388, 368);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 12;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(519, 367);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dateTimePickerHora
            // 
            this.dateTimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHora.Location = new System.Drawing.Point(193, 174);
            this.dateTimePickerHora.Name = "dateTimePickerHora";
            this.dateTimePickerHora.Size = new System.Drawing.Size(82, 20);
            this.dateTimePickerHora.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Día";
            // 
            // comboBoxDia
            // 
            this.comboBoxDia.FormattingEnabled = true;
            this.comboBoxDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado"});
            this.comboBoxDia.Location = new System.Drawing.Point(75, 173);
            this.comboBoxDia.Name = "comboBoxDia";
            this.comboBoxDia.Size = new System.Drawing.Size(100, 21);
            this.comboBoxDia.TabIndex = 16;
            // 
            // FCrearActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerHora);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.textBoxCantMax);
            this.Controls.Add(this.textBoxCosto);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelCantMax);
            this.Controls.Add(this.labelCosto);
            this.Controls.Add(this.listBoxProfesores);
            this.Controls.Add(this.labelProfesor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelDescripcion);
            this.Name = "FCrearActividad";
            this.Text = "Crear nueva actividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProfesor;
        private System.Windows.Forms.ListBox listBoxProfesores;
        private System.Windows.Forms.Label labelCosto;
        private System.Windows.Forms.Label labelCantMax;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxCosto;
        private System.Windows.Forms.TextBox textBoxCantMax;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dateTimePickerHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDia;
    }
}