﻿namespace Ingenieria_Software_Prototipo
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
            this.btnAsignarJurado = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbEquipo = new System.Windows.Forms.GroupBox();
            this.gbJurado = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labNombre = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labCedula = new System.Windows.Forms.Label();
            this.gbPropuestas = new System.Windows.Forms.GroupBox();
            this.gbTrabajos = new System.Windows.Forms.GroupBox();
            this.cbJurados = new System.Windows.Forms.ComboBox();
            this.gbJurados = new System.Windows.Forms.GroupBox();
            this.cbPropuestas = new System.Windows.Forms.ComboBox();
            this.cbTrabajos = new System.Windows.Forms.ComboBox();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.gbEquipo.SuspendLayout();
            this.gbJurado.SuspendLayout();
            this.gbPropuestas.SuspendLayout();
            this.gbTrabajos.SuspendLayout();
            this.gbJurados.SuspendLayout();
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
            // 
            // btnConsultarTrabajoFinal
            // 
            this.btnConsultarTrabajoFinal.Location = new System.Drawing.Point(381, 25);
            this.btnConsultarTrabajoFinal.Name = "btnConsultarTrabajoFinal";
            this.btnConsultarTrabajoFinal.Size = new System.Drawing.Size(125, 23);
            this.btnConsultarTrabajoFinal.TabIndex = 2;
            this.btnConsultarTrabajoFinal.Text = "Consultar Trabajo Final";
            this.btnConsultarTrabajoFinal.UseVisualStyleBackColor = true;
            // 
            // btnAsignarJurado
            // 
            this.btnAsignarJurado.Location = new System.Drawing.Point(397, 25);
            this.btnAsignarJurado.Name = "btnAsignarJurado";
            this.btnAsignarJurado.Size = new System.Drawing.Size(86, 23);
            this.btnAsignarJurado.TabIndex = 3;
            this.btnAsignarJurado.Text = "Asignar Jurado";
            this.btnAsignarJurado.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // gbEquipo
            // 
            this.gbEquipo.Controls.Add(this.label1);
            this.gbEquipo.Controls.Add(this.textBox1);
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
            this.gbJurado.Controls.Add(this.textBox3);
            this.gbJurado.Controls.Add(this.labNombre);
            this.gbJurado.Controls.Add(this.textBox2);
            this.gbJurado.Controls.Add(this.labCedula);
            this.gbJurado.Controls.Add(this.btnAsignarJurado);
            this.gbJurado.Location = new System.Drawing.Point(13, 84);
            this.gbJurado.Name = "gbJurado";
            this.gbJurado.Size = new System.Drawing.Size(522, 62);
            this.gbJurado.TabIndex = 6;
            this.gbJurado.TabStop = false;
            this.gbJurado.Text = "Jurado";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(73, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(20, 30);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(47, 13);
            this.labNombre.TabIndex = 6;
            this.labNombre.Text = "Nombre:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(259, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // labCedula
            // 
            this.labCedula.AutoSize = true;
            this.labCedula.Location = new System.Drawing.Point(210, 31);
            this.labCedula.Name = "labCedula";
            this.labCedula.Size = new System.Drawing.Size(43, 13);
            this.labCedula.TabIndex = 4;
            this.labCedula.Text = "Cédula:";
            // 
            // gbPropuestas
            // 
            this.gbPropuestas.Controls.Add(this.cbPropuestas);
            this.gbPropuestas.Location = new System.Drawing.Point(13, 153);
            this.gbPropuestas.Name = "gbPropuestas";
            this.gbPropuestas.Size = new System.Drawing.Size(158, 52);
            this.gbPropuestas.TabIndex = 7;
            this.gbPropuestas.TabStop = false;
            this.gbPropuestas.Text = "Propuestas";
            // 
            // gbTrabajos
            // 
            this.gbTrabajos.Controls.Add(this.cbTrabajos);
            this.gbTrabajos.Location = new System.Drawing.Point(177, 153);
            this.gbTrabajos.Name = "gbTrabajos";
            this.gbTrabajos.Size = new System.Drawing.Size(170, 52);
            this.gbTrabajos.TabIndex = 8;
            this.gbTrabajos.TabStop = false;
            this.gbTrabajos.Text = "Trabajos";
            // 
            // cbJurados
            // 
            this.cbJurados.FormattingEnabled = true;
            this.cbJurados.Location = new System.Drawing.Point(18, 19);
            this.cbJurados.Name = "cbJurados";
            this.cbJurados.Size = new System.Drawing.Size(147, 21);
            this.cbJurados.TabIndex = 9;
            // 
            // gbJurados
            // 
            this.gbJurados.Controls.Add(this.cbJurados);
            this.gbJurados.Location = new System.Drawing.Point(353, 153);
            this.gbJurados.Name = "gbJurados";
            this.gbJurados.Size = new System.Drawing.Size(181, 52);
            this.gbJurados.TabIndex = 9;
            this.gbJurados.TabStop = false;
            this.gbJurados.Text = "Jurados";
            // 
            // cbPropuestas
            // 
            this.cbPropuestas.FormattingEnabled = true;
            this.cbPropuestas.Location = new System.Drawing.Point(12, 19);
            this.cbPropuestas.Name = "cbPropuestas";
            this.cbPropuestas.Size = new System.Drawing.Size(130, 21);
            this.cbPropuestas.TabIndex = 0;
            // 
            // cbTrabajos
            // 
            this.cbTrabajos.FormattingEnabled = true;
            this.cbTrabajos.Location = new System.Drawing.Point(15, 19);
            this.cbTrabajos.Name = "cbTrabajos";
            this.cbTrabajos.Size = new System.Drawing.Size(139, 21);
            this.cbTrabajos.TabIndex = 0;
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(12, 211);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(523, 252);
            this.grilla.TabIndex = 10;
            // 
            // GUIAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 475);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.gbJurados);
            this.Controls.Add(this.gbTrabajos);
            this.Controls.Add(this.gbPropuestas);
            this.Controls.Add(this.gbJurado);
            this.Controls.Add(this.gbEquipo);
            this.Name = "GUIAdministrador";
            this.Text = "Administrador";
            this.gbEquipo.ResumeLayout(false);
            this.gbEquipo.PerformLayout();
            this.gbJurado.ResumeLayout(false);
            this.gbJurado.PerformLayout();
            this.gbPropuestas.ResumeLayout(false);
            this.gbTrabajos.ResumeLayout(false);
            this.gbJurados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultarPropuesta;
        private System.Windows.Forms.Button btnConsultarTrabajoFinal;
        private System.Windows.Forms.Button btnAsignarJurado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbEquipo;
        private System.Windows.Forms.GroupBox gbJurado;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labCedula;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.GroupBox gbPropuestas;
        private System.Windows.Forms.GroupBox gbTrabajos;
        private System.Windows.Forms.ComboBox cbPropuestas;
        private System.Windows.Forms.ComboBox cbTrabajos;
        private System.Windows.Forms.ComboBox cbJurados;
        private System.Windows.Forms.GroupBox gbJurados;
        private System.Windows.Forms.DataGridView grilla;
    }
}