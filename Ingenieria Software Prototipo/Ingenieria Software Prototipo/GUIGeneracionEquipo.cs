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
    public partial class GUIGeneracionEquipo : Form
    {
        private ProgramaAcademico programaAcademico;
        public GUIGeneracionEquipo(ProgramaAcademico pPrograma)
        {
            InitializeComponent();
            programaAcademico = pPrograma;
        }

        private void btnConsultarPropuesta_Click(object sender, EventArgs e)
        {
            Estudiante stud1 = new Estudiante(txtNom1.Text, txtCod1.Text);
            Estudiante stud2 = new Estudiante(txtNom2.Text, txtCod2.Text);
            Estudiante stud3 = new Estudiante(txtNom3.Text, txtCod3.Text);
            Estudiante stud4 = new Estudiante(txtNom4.Text, txtCod4.Text);
            Estudiante[] studs = new Estudiante[4];
            studs[0] = stud1;
            studs[1] = stud2;
            studs[2] = stud3;
            studs[3] = stud4;
            Equipo equipo = new Equipo(studs);
            programaAcademico.agregarEquipo(equipo);
            GUIEstudiante interfazEstudiante = new GUIEstudiante(programaAcademico,equipo);
            this.Visible = false;
            interfazEstudiante.Show();
        }
    }
}
