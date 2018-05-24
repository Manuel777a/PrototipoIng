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
    public partial class GUIAdministrador : Form
    {
        private ProgramaAcademico programaAcademico;
        public GUIAdministrador()
        {
            InitializeComponent();
            programaAcademico = new ProgramaAcademico();
        }

        private void btnConsultarPropuesta_Click(object sender, EventArgs e)
        {
            if (txtCodigoEst.Text.Equals("") || txtCodigoEst.Text == null)
            {
                MessageBox.Show("ERROR. Ingrese el código del estudiante");
            }

        }

        private void btnConsultarTrabajoFinal_Click(object sender, EventArgs e)
        {
            if (txtCodigoEst.Text.Equals("") || txtCodigoEst.Text == null)
            {
                MessageBox.Show("ERROR. Ingrese el código del estudiante");
            }

        }

        private void btnAsignarJurado_Click(object sender, EventArgs e)
        {

            if (txtCodigoEst.Text.Equals("") || txtCodigoEst.Text == null)
            {
                MessageBox.Show("ERROR. Ingrese el código del estudiante");
            }
            else if (txtCodigoJurado1.Equals("") || txtCodigoEst.Text == null)
            {
                MessageBox.Show("ERROR. Ingrese el código del jurado");
            }
            else
            {
                Jurado jurado1 = new Jurado(txtCodigoJurado1.Text, txtNombreJurado1.Text);

                Jurado jurado2 = new Jurado(txtCodigoJurado2.Text, txtNombreJurado2.Text);

                Equipo equipo = programaAcademico.buscarEquipo(txtCodigoEst.Text);
                TrabajoDeGrado trabajoDeGrado = equipo.darTrabajoDeGrado();
                if (trabajoDeGrado == null)
                {
                    MessageBox.Show("ERROR. El equipo no tiene un trabajo de grado.");
                    return;
                }
                else
                {
                    trabajoDeGrado.asignarJurado(jurado1, jurado2);
                    MessageBox.Show("Jurados asignados.");
                }
            }


        }
    }
}
