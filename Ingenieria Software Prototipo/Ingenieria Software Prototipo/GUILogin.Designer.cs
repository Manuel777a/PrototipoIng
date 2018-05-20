namespace Ingenieria_Software_Prototipo
{
    partial class GUILogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.comboBoxSoy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttIngresar = new System.Windows.Forms.Button();
            this.buttSalir = new System.Windows.Forms.Button();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Contraseña";
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(101, 35);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(121, 20);
            this.textBoxContraseña.TabIndex = 3;
            // 
            // comboBoxSoy
            // 
            this.comboBoxSoy.FormattingEnabled = true;
            this.comboBoxSoy.Items.AddRange(new object[] {
            "Estudiante",
            "Administrativo",
            "Jurado"});
            this.comboBoxSoy.Location = new System.Drawing.Point(101, 61);
            this.comboBoxSoy.Name = "comboBoxSoy";
            this.comboBoxSoy.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSoy.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "&Soy";
            // 
            // buttIngresar
            // 
            this.buttIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttIngresar.Location = new System.Drawing.Point(27, 94);
            this.buttIngresar.Name = "buttIngresar";
            this.buttIngresar.Size = new System.Drawing.Size(75, 23);
            this.buttIngresar.TabIndex = 6;
            this.buttIngresar.Text = "Ingresar";
            this.buttIngresar.UseVisualStyleBackColor = true;
            this.buttIngresar.Click += new System.EventHandler(this.buttIngresar_Click);
            // 
            // buttSalir
            // 
            this.buttSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttSalir.Location = new System.Drawing.Point(118, 94);
            this.buttSalir.Name = "buttSalir";
            this.buttSalir.Size = new System.Drawing.Size(75, 23);
            this.buttSalir.TabIndex = 7;
            this.buttSalir.Text = "Salir";
            this.buttSalir.UseVisualStyleBackColor = true;
            this.buttSalir.Click += new System.EventHandler(this.buttSalir_Click);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(101, 9);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(121, 20);
            this.textBoxUsuario.TabIndex = 2;
            // 
            // GUILogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 121);
            this.Controls.Add(this.buttSalir);
            this.Controls.Add(this.buttIngresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSoy);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUILogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.ComboBox comboBoxSoy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttIngresar;
        private System.Windows.Forms.Button buttSalir;
        private System.Windows.Forms.TextBox textBoxUsuario;
    }
}

