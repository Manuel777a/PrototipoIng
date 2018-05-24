namespace Ingenieria_Software_Prototipo
{
    partial class GUIEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIEstudiante));
            this.gbEquipo = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNom2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNom1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNom4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNom3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxCalificacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRuta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxModalidad = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonExaminar = new System.Windows.Forms.Button();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.gbEquipo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEquipo
            // 
            this.gbEquipo.Controls.Add(this.label5);
            this.gbEquipo.Controls.Add(this.txtNom2);
            this.gbEquipo.Controls.Add(this.label6);
            this.gbEquipo.Controls.Add(this.txtNom1);
            this.gbEquipo.Controls.Add(this.label7);
            this.gbEquipo.Controls.Add(this.txtNom4);
            this.gbEquipo.Controls.Add(this.label8);
            this.gbEquipo.Controls.Add(this.txtNom3);
            this.gbEquipo.Location = new System.Drawing.Point(21, 12);
            this.gbEquipo.Name = "gbEquipo";
            this.gbEquipo.Size = new System.Drawing.Size(805, 89);
            this.gbEquipo.TabIndex = 7;
            this.gbEquipo.TabStop = false;
            this.gbEquipo.Text = "&Equipo conformado por:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nombre del Estudiante:";
            // 
            // txtNom2
            // 
            this.txtNom2.Location = new System.Drawing.Point(536, 55);
            this.txtNom2.Name = "txtNom2";
            this.txtNom2.ReadOnly = true;
            this.txtNom2.Size = new System.Drawing.Size(238, 20);
            this.txtNom2.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nombre del Estudiante:";
            // 
            // txtNom1
            // 
            this.txtNom1.Location = new System.Drawing.Point(536, 25);
            this.txtNom1.Name = "txtNom1";
            this.txtNom1.ReadOnly = true;
            this.txtNom1.Size = new System.Drawing.Size(238, 20);
            this.txtNom1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nombre del Estudiante:";
            // 
            // txtNom4
            // 
            this.txtNom4.Location = new System.Drawing.Point(140, 51);
            this.txtNom4.Name = "txtNom4";
            this.txtNom4.ReadOnly = true;
            this.txtNom4.Size = new System.Drawing.Size(238, 20);
            this.txtNom4.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nombre del Estudiante:";
            // 
            // txtNom3
            // 
            this.txtNom3.Location = new System.Drawing.Point(140, 25);
            this.txtNom3.Name = "txtNom3";
            this.txtNom3.ReadOnly = true;
            this.txtNom3.Size = new System.Drawing.Size(238, 20);
            this.txtNom3.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.axAcroPDF1);
            this.groupBox1.Controls.Add(this.buttonExaminar);
            this.groupBox1.Controls.Add(this.dtpFechaEntrega);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBoxCalificacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxRuta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxModalidad);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.textBoxTitulo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(21, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 234);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propuesta de Grado";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Enabled = false;
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(99, 128);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(152, 20);
            this.dtpFechaEntrega.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "&Fecha Entrega:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Quiero modificar mi propuesta";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBoxCalificacion
            // 
            this.comboBoxCalificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCalificacion.FormattingEnabled = true;
            this.comboBoxCalificacion.Items.AddRange(new object[] {
            "Aprobada",
            "Devuelta para Correciones",
            "No aceptada"});
            this.comboBoxCalificacion.Location = new System.Drawing.Point(99, 101);
            this.comboBoxCalificacion.Name = "comboBoxCalificacion";
            this.comboBoxCalificacion.Size = new System.Drawing.Size(152, 21);
            this.comboBoxCalificacion.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "&Calificacion:";
            // 
            // textBoxRuta
            // 
            this.textBoxRuta.Location = new System.Drawing.Point(99, 48);
            this.textBoxRuta.Name = "textBoxRuta";
            this.textBoxRuta.ReadOnly = true;
            this.textBoxRuta.Size = new System.Drawing.Size(340, 20);
            this.textBoxRuta.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "&Ruta Archivo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "&Modalidad:";
            // 
            // comboBoxModalidad
            // 
            this.comboBoxModalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModalidad.FormattingEnabled = true;
            this.comboBoxModalidad.Items.AddRange(new object[] {
            "Monografia",
            "Asistencia De Investigacion",
            "Trabajo de Investigacion",
            "Opcion Emprendimiento"});
            this.comboBoxModalidad.Location = new System.Drawing.Point(99, 74);
            this.comboBoxModalidad.Name = "comboBoxModalidad";
            this.comboBoxModalidad.Size = new System.Drawing.Size(152, 21);
            this.comboBoxModalidad.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "&Titulo:";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(99, 22);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.ReadOnly = true;
            this.textBoxTitulo.Size = new System.Drawing.Size(340, 20);
            this.textBoxTitulo.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Quiero subir una propuesta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExaminar
            // 
            this.buttonExaminar.Location = new System.Drawing.Point(374, 72);
            this.buttonExaminar.Name = "buttonExaminar";
            this.buttonExaminar.Size = new System.Drawing.Size(65, 23);
            this.buttonExaminar.TabIndex = 14;
            this.buttonExaminar.Text = "Examinar";
            this.buttonExaminar.UseVisualStyleBackColor = true;
            this.buttonExaminar.Click += new System.EventHandler(this.buttonExaminar_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(445, 19);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(346, 209);
            this.axAcroPDF1.TabIndex = 15;
            // 
            // GUIEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 395);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbEquipo);
            this.Name = "GUIEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiante";
            this.gbEquipo.ResumeLayout(false);
            this.gbEquipo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEquipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNom2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNom1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNom4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNom3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxModalidad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxCalificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRuta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Button buttonExaminar;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
    }
}