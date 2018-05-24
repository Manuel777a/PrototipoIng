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
        private ProgramaAcademico programaAcademico;
        public GUILogin()
        {
            InitializeComponent();
        }

        private void buttIngresar_Click(object sender, EventArgs e)
        {
            string soy = Convert.ToString(comboBoxSoy.SelectedItem);
            string usuario = textBoxUsuario.Text;
            string contraseña = textBoxContraseña.Text; 
            if(!soy.Equals("") && !usuario.Equals("") && !contraseña.Equals(""))
            {
                if(soy.Equals("Jurado"))
                {
                    // toca pasarle por parametro el programaAcademico
                    GUIJurado jurado = new GUIJurado();
                    jurado.Show();
                }
                else if(soy.Equals("Estudiante"))
                {
                    // toca pasarle por parametro el programaAcademico
                    GUIEstudiantes estudiante = new GUIEstudiantes();
                    estudiante.Show();

                }
                else if(soy.Equals("Administrativo"))
                {
                    // toca pasarle por parametro el programaAcademico
                    GUIAdministrativos admin = new GUIAdministrativos();
                    admin.Show();

                }
            }       
        }
        private void buttSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salir");
        }
    }
}
