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
            programaAcademico = new ProgramaAcademico();
        }

        private void buttIngresar_Click(object sender, EventArgs e)
        {
            string soy = Convert.ToString(comboBoxSoy.SelectedItem);
            string usuario = textBoxUsuario.Text;
            string contraseña = textBoxContraseña.Text;
            if (!soy.Equals("") && !usuario.Equals("") && !contraseña.Equals(""))
            {
                if (soy.Equals("Jurado"))
                {

                    // lanzar la interfaz jurado pasandole por parametro el programa academico

                }
                else if (soy.Equals("Estudiante"))
                {
                    if (programaAcademico.buscarEquipo(textBoxUsuario.Text) == null)
                    {
                        GUIGeneracionEquipo interfazGeneracionEquipo = new GUIGeneracionEquipo(programaAcademico);
                        interfazGeneracionEquipo.Show();

                    }
                    else
                    {
                        Equipo equipo = programaAcademico.buscarEquipo(textBoxUsuario.Text);
                        GUIEstudiante interfazEstudiante = new GUIEstudiante(programaAcademico, equipo);
                        interfazEstudiante.Show();
                    }
                }
                // lanzar la interfaz estudiante pasandole por parametro el programa academico
                else if (soy.Equals("Administrativo"))
                {

                    GUIAdministrador interfazAdministrativo = new GUIAdministrador(programaAcademico);
                    interfazAdministrativo.Show();                    // lanzar la interfaz administrativo pasandole por parametro el programa academico

                }
            }
            else
            {
                MessageBox.Show("Error , Llene todos los campos para realizar Loggin");
            }


        }
    }
}
       
    


