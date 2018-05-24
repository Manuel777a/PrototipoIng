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
    public partial class GUIEstudiante : Form
    {
        private Equipo equipo;
        private ProgramaAcademico programaAcademico;
        public GUIEstudiante(ProgramaAcademico pPrograma,Equipo pEquipo)   
        {
            InitializeComponent();
            programaAcademico = pPrograma;
            equipo = pEquipo;
            txtNom1.Text = equipo.darEstudiantes[0].ToString();
            txtNom2.Text = equipo.darEstudiantes[1].ToString();
            txtNom3.Text = equipo.darEstudiantes[2].ToString();
            txtNom4.Text = equipo.darEstudiantes[3].ToString();

        }

        
    }
}
