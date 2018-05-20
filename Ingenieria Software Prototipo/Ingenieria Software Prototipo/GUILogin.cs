using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingenieria_Software_Prototipo
{
    public partial class GUILogin : Form
    {
        public GUILogin()
        {
            InitializeComponent();
        }

        private void buttIngresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingresar");
        }

        private void buttSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salir");
        }
    }
}
