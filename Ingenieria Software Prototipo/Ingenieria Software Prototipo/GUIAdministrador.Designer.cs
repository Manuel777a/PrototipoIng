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
            this.grilla = new System.Windows.Forms.DataGridView();
            this.gbEquipo.SuspendLayout();
            this.gbJurado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo del Estudiante:";
            // 
            // btnConsultarPropuesta
            // 
            this.btnConsultarPropuesta.Location = new System.Drawing.Point(246, 25);
            this.btnConsultarPropuesta.Name = "btnConsultarPropuesta";
            this.btnConsultarPropuesta.Size = new System.Drawing.Size(114, 23);
            this.btnConsultarPropuesta.TabIndex = 1;
            this.btnConsultarPropuesta.Text = "Consultar Propuesta";
            this.btnConsultarPropuesta.UseVisualStyleBackColor = true;
            this.btnConsultarPropuesta.Click += new System.EventHandler(this.btnConsultarPropuesta_Click);
            // 
            // btnConsultarTrabajoFinal
            // 
            this.btnConsultarTrabajoFinal.Location = new System.Drawing.Point(381, 25);
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
            this.txtCodigoEst.Location = new System.Drawing.Point(140, 27);
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
            this.gbEquipo.Size = new System.Drawing.Size(523, 65);
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
            this.gbJurado.Location = new System.Drawing.Point(13, 84);
            this.gbJurado.Name = "gbJurado";
            this.gbJurado.Size = new System.Drawing.Size(522, 102);
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
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(11, 204);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(523, 252);
            this.grilla.TabIndex = 10;
            // 
            // GUIAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 466);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.gbJurado);
            this.Controls.Add(this.gbEquipo);
            this.Name = "GUIAdministrador";
            this.Text = "Administrador";
            this.gbEquipo.ResumeLayout(false);
            this.gbEquipo.PerformLayout();
            this.gbJurado.ResumeLayout(false);
            this.gbJurado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
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
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboJurado;
    }
}