namespace Ingenieria_Software_Prototipo
{
    partial class GUIAdministrador
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
            this.btnConsultarPropuesta = new System.Windows.Forms.Button();
            this.btnConsultarTrabajoFinal = new System.Windows.Forms.Button();
            this.btnAsignarJurados = new System.Windows.Forms.Button();
            this.txtCodigoEst = new System.Windows.Forms.TextBox();
            this.gbEquipo = new System.Windows.Forms.GroupBox();
            this.gbJurado = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboJurado = new System.Windows.Forms.ComboBox();
            this.txtNombreJurado1 = new System.Windows.Forms.TextBox();
            this.labNombre = new System.Windows.Forms.Label();
            this.txtCodigoJurado1 = new System.Windows.Forms.TextBox();
            this.labCedula = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtObservacionesPropuesta = new System.Windows.Forms.TextBox();
            this.dtpFechaEntregaPropuesta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCalificacionPropuesta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRutaPropuesta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbModalidadPropuesta = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTituloPropuesta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtObservacionesTrabajo = new System.Windows.Forms.TextBox();
            this.dtpTrabajo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCalificacionTrabajo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRutaTrabajo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbModalidadTrabajo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTituloTrabajo = new System.Windows.Forms.TextBox();
            this.gbEquipo.SuspendLayout();
            this.gbJurado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo del Estudiante:";
            // 
            // btnConsultarPropuesta
            // 
            this.btnConsultarPropuesta.Location = new System.Drawing.Point(233, 25);
            this.btnConsultarPropuesta.Name = "btnConsultarPropuesta";
            this.btnConsultarPropuesta.Size = new System.Drawing.Size(114, 23);
            this.btnConsultarPropuesta.TabIndex = 1;
            this.btnConsultarPropuesta.Text = "Consultar Propuesta";
            this.btnConsultarPropuesta.UseVisualStyleBackColor = true;
            this.btnConsultarPropuesta.Click += new System.EventHandler(this.btnConsultarPropuesta_Click);
            // 
            // btnConsultarTrabajoFinal
            // 
            this.btnConsultarTrabajoFinal.Location = new System.Drawing.Point(353, 25);
            this.btnConsultarTrabajoFinal.Name = "btnConsultarTrabajoFinal";
            this.btnConsultarTrabajoFinal.Size = new System.Drawing.Size(125, 23);
            this.btnConsultarTrabajoFinal.TabIndex = 2;
            this.btnConsultarTrabajoFinal.Text = "Consultar Trabajo Final";
            this.btnConsultarTrabajoFinal.UseVisualStyleBackColor = true;
            this.btnConsultarTrabajoFinal.Click += new System.EventHandler(this.btnConsultarTrabajoFinal_Click);
            // 
            // btnAsignarJurados
            // 
            this.btnAsignarJurados.Location = new System.Drawing.Point(382, 31);
            this.btnAsignarJurados.Name = "btnAsignarJurados";
            this.btnAsignarJurados.Size = new System.Drawing.Size(86, 23);
            this.btnAsignarJurados.TabIndex = 3;
            this.btnAsignarJurados.Text = "Asignar Jurado";
            this.btnAsignarJurados.UseVisualStyleBackColor = true;
            this.btnAsignarJurados.Click += new System.EventHandler(this.btnAsignarJurado_Click);
            // 
            // txtCodigoEst
            // 
            this.txtCodigoEst.Location = new System.Drawing.Point(127, 27);
            this.txtCodigoEst.Name = "txtCodigoEst";
            this.txtCodigoEst.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoEst.TabIndex = 4;
            // 
            // gbEquipo
            // 
            this.gbEquipo.Controls.Add(this.label1);
            this.gbEquipo.Controls.Add(this.txtCodigoEst);
            this.gbEquipo.Controls.Add(this.btnConsultarTrabajoFinal);
            this.gbEquipo.Controls.Add(this.btnConsultarPropuesta);
            this.gbEquipo.Location = new System.Drawing.Point(12, 12);
            this.gbEquipo.Name = "gbEquipo";
            this.gbEquipo.Size = new System.Drawing.Size(499, 65);
            this.gbEquipo.TabIndex = 5;
            this.gbEquipo.TabStop = false;
            this.gbEquipo.Text = "Equipo";
            // 
            // gbJurado
            // 
            this.gbJurado.Controls.Add(this.label4);
            this.gbJurado.Controls.Add(this.comboJurado);
            this.gbJurado.Controls.Add(this.txtNombreJurado1);
            this.gbJurado.Controls.Add(this.labNombre);
            this.gbJurado.Controls.Add(this.txtCodigoJurado1);
            this.gbJurado.Controls.Add(this.labCedula);
            this.gbJurado.Controls.Add(this.btnAsignarJurados);
            this.gbJurado.Location = new System.Drawing.Point(13, 478);
            this.gbJurado.Name = "gbJurado";
            this.gbJurado.Size = new System.Drawing.Size(498, 102);
            this.gbJurado.TabIndex = 6;
            this.gbJurado.TabStop = false;
            this.gbJurado.Text = "Jurado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Jurado existente: ";
            // 
            // comboJurado
            // 
            this.comboJurado.FormattingEnabled = true;
            this.comboJurado.Location = new System.Drawing.Point(160, 62);
            this.comboJurado.Name = "comboJurado";
            this.comboJurado.Size = new System.Drawing.Size(203, 21);
            this.comboJurado.TabIndex = 12;
            // 
            // txtNombreJurado1
            // 
            this.txtNombreJurado1.Location = new System.Drawing.Point(117, 29);
            this.txtNombreJurado1.Name = "txtNombreJurado1";
            this.txtNombreJurado1.Size = new System.Drawing.Size(100, 20);
            this.txtNombreJurado1.TabIndex = 7;
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(64, 31);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(47, 13);
            this.labNombre.TabIndex = 6;
            this.labNombre.Text = "Nombre:";
            // 
            // txtCodigoJurado1
            // 
            this.txtCodigoJurado1.Location = new System.Drawing.Point(263, 31);
            this.txtCodigoJurado1.Name = "txtCodigoJurado1";
            this.txtCodigoJurado1.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoJurado1.TabIndex = 5;
            // 
            // labCedula
            // 
            this.labCedula.AutoSize = true;
            this.labCedula.Location = new System.Drawing.Point(223, 31);
            this.labCedula.Name = "labCedula";
            this.labCedula.Size = new System.Drawing.Size(43, 13);
            this.labCedula.TabIndex = 4;
            this.labCedula.Text = "Cédula:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtObservacionesPropuesta);
            this.groupBox1.Controls.Add(this.dtpFechaEntregaPropuesta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbCalificacionPropuesta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRutaPropuesta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbModalidadPropuesta);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtTituloPropuesta);
            this.groupBox1.Location = new System.Drawing.Point(13, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 165);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propuesta de Grado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(272, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Observaciones: ";
            // 
            // txtObservacionesPropuesta
            // 
            this.txtObservacionesPropuesta.Location = new System.Drawing.Point(272, 94);
            this.txtObservacionesPropuesta.Multiline = true;
            this.txtObservacionesPropuesta.Name = "txtObservacionesPropuesta";
            this.txtObservacionesPropuesta.Size = new System.Drawing.Size(220, 47);
            this.txtObservacionesPropuesta.TabIndex = 16;
            // 
            // dtpFechaEntregaPropuesta
            // 
            this.dtpFechaEntregaPropuesta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntregaPropuesta.Location = new System.Drawing.Point(99, 128);
            this.dtpFechaEntregaPropuesta.Name = "dtpFechaEntregaPropuesta";
            this.dtpFechaEntregaPropuesta.Size = new System.Drawing.Size(152, 20);
            this.dtpFechaEntregaPropuesta.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "&Fecha Entrega:";
            // 
            // cbCalificacionPropuesta
            // 
            this.cbCalificacionPropuesta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCalificacionPropuesta.FormattingEnabled = true;
            this.cbCalificacionPropuesta.Items.AddRange(new object[] {
            "Aprobada",
            "Devuelta para Correciones",
            "No aceptada"});
            this.cbCalificacionPropuesta.Location = new System.Drawing.Point(99, 101);
            this.cbCalificacionPropuesta.Name = "cbCalificacionPropuesta";
            this.cbCalificacionPropuesta.Size = new System.Drawing.Size(152, 21);
            this.cbCalificacionPropuesta.TabIndex = 10;
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
            // txtRutaPropuesta
            // 
            this.txtRutaPropuesta.Location = new System.Drawing.Point(99, 48);
            this.txtRutaPropuesta.Name = "txtRutaPropuesta";
            this.txtRutaPropuesta.ReadOnly = true;
            this.txtRutaPropuesta.Size = new System.Drawing.Size(260, 20);
            this.txtRutaPropuesta.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "&Ruta Archivo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "&Modalidad:";
            // 
            // cbModalidadPropuesta
            // 
            this.cbModalidadPropuesta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModalidadPropuesta.FormattingEnabled = true;
            this.cbModalidadPropuesta.Items.AddRange(new object[] {
            "Monografia",
            "Asistencia De Investigacion",
            "Trabajo de Investigacion",
            "Opcion Emprendimiento"});
            this.cbModalidadPropuesta.Location = new System.Drawing.Point(99, 74);
            this.cbModalidadPropuesta.Name = "cbModalidadPropuesta";
            this.cbModalidadPropuesta.Size = new System.Drawing.Size(152, 21);
            this.cbModalidadPropuesta.TabIndex = 5;
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
            // txtTituloPropuesta
            // 
            this.txtTituloPropuesta.Location = new System.Drawing.Point(99, 18);
            this.txtTituloPropuesta.Name = "txtTituloPropuesta";
            this.txtTituloPropuesta.ReadOnly = true;
            this.txtTituloPropuesta.Size = new System.Drawing.Size(264, 20);
            this.txtTituloPropuesta.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtObservacionesTrabajo);
            this.groupBox2.Controls.Add(this.dtpTrabajo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbCalificacionTrabajo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtRutaTrabajo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbModalidadTrabajo);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtTituloTrabajo);
            this.groupBox2.Location = new System.Drawing.Point(13, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 201);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trabajo de grado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(257, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Observaciones: ";
            // 
            // txtObservacionesTrabajo
            // 
            this.txtObservacionesTrabajo.Location = new System.Drawing.Point(257, 101);
            this.txtObservacionesTrabajo.Multiline = true;
            this.txtObservacionesTrabajo.Name = "txtObservacionesTrabajo";
            this.txtObservacionesTrabajo.Size = new System.Drawing.Size(220, 47);
            this.txtObservacionesTrabajo.TabIndex = 14;
            // 
            // dtpTrabajo
            // 
            this.dtpTrabajo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTrabajo.Location = new System.Drawing.Point(99, 128);
            this.dtpTrabajo.Name = "dtpTrabajo";
            this.dtpTrabajo.Size = new System.Drawing.Size(152, 20);
            this.dtpTrabajo.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "&Fecha Entrega:";
            // 
            // cbCalificacionTrabajo
            // 
            this.cbCalificacionTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCalificacionTrabajo.FormattingEnabled = true;
            this.cbCalificacionTrabajo.Items.AddRange(new object[] {
            "Aprobada",
            "Devuelta para Correciones",
            "No aceptada"});
            this.cbCalificacionTrabajo.Location = new System.Drawing.Point(99, 101);
            this.cbCalificacionTrabajo.Name = "cbCalificacionTrabajo";
            this.cbCalificacionTrabajo.Size = new System.Drawing.Size(152, 21);
            this.cbCalificacionTrabajo.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "&Calificacion:";
            // 
            // txtRutaTrabajo
            // 
            this.txtRutaTrabajo.Location = new System.Drawing.Point(99, 48);
            this.txtRutaTrabajo.Name = "txtRutaTrabajo";
            this.txtRutaTrabajo.ReadOnly = true;
            this.txtRutaTrabajo.Size = new System.Drawing.Size(260, 20);
            this.txtRutaTrabajo.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "&Ruta Archivo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "&Modalidad:";
            // 
            // cbModalidadTrabajo
            // 
            this.cbModalidadTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModalidadTrabajo.FormattingEnabled = true;
            this.cbModalidadTrabajo.Items.AddRange(new object[] {
            "Monografia",
            "Asistencia De Investigacion",
            "Trabajo de Investigacion",
            "Opcion Emprendimiento"});
            this.cbModalidadTrabajo.Location = new System.Drawing.Point(99, 74);
            this.cbModalidadTrabajo.Name = "cbModalidadTrabajo";
            this.cbModalidadTrabajo.Size = new System.Drawing.Size(152, 21);
            this.cbModalidadTrabajo.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "&Titulo:";
            // 
            // txtTituloTrabajo
            // 
            this.txtTituloTrabajo.Location = new System.Drawing.Point(99, 18);
            this.txtTituloTrabajo.Name = "txtTituloTrabajo";
            this.txtTituloTrabajo.ReadOnly = true;
            this.txtTituloTrabajo.Size = new System.Drawing.Size(264, 20);
            this.txtTituloTrabajo.TabIndex = 4;
            // 
            // GUIAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 614);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbJurado);
            this.Controls.Add(this.gbEquipo);
            this.Name = "GUIAdministrador";
            this.Text = "Administrador";
            this.gbEquipo.ResumeLayout(false);
            this.gbEquipo.PerformLayout();
            this.gbJurado.ResumeLayout(false);
            this.gbJurado.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultarPropuesta;
        private System.Windows.Forms.Button btnConsultarTrabajoFinal;
        private System.Windows.Forms.Button btnAsignarJurados;
        private System.Windows.Forms.TextBox txtCodigoEst;
        private System.Windows.Forms.GroupBox gbEquipo;
        private System.Windows.Forms.GroupBox gbJurado;
        private System.Windows.Forms.TextBox txtCodigoJurado1;
        private System.Windows.Forms.Label labCedula;
        private System.Windows.Forms.TextBox txtNombreJurado1;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboJurado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaEntregaPropuesta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCalificacionPropuesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRutaPropuesta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbModalidadPropuesta;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTituloPropuesta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtObservacionesPropuesta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtObservacionesTrabajo;
        private System.Windows.Forms.DateTimePicker dtpTrabajo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCalificacionTrabajo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRutaTrabajo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbModalidadTrabajo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTituloTrabajo;
    }
}