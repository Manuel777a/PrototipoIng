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
        public GUIAdministrador(ProgramaAcademico pPrograma)
        {
            InitializeComponent();
            programaAcademico = pPrograma;
            llenarCombo();
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
            Equipo equipo = programaAcademico.buscarEquipo(txtCodigoEst.Text);
            TrabajoDeGrado trabajo = equipo.darTrabajoDeGrado();
            if (trabajo == null)
            {
                MessageBox.Show("ERROR. El estudiante no tiene un trabajo de grado registrado");
            }
            else
            {
                grilla.Rows[0].HeaderCell.Value = "Título";

                grilla.Rows[1].HeaderCell.Value = "Modalidad";

                grilla.Rows[2].HeaderCell.Value = "Observaciones";

                grilla.Rows[3].HeaderCell.Value = "Fecha de entrega";

                grilla.Rows[4].HeaderCell.Value = "Calificacion";

                grilla.Rows[5].HeaderCell.Value = "Ruta del documento";
            }
        }

        private void btnAsignarJurado_Click(object sender, EventArgs e)
        {

            
            programaAcademico.agregarJurado((Jurado)comboJurado.SelectedItem);

           


            llenarCombo();
        }

       
        private void llenarCombo()
        {
        List<Jurado> lista =  programaAcademico.darJurados;
            for (int i = 0; i < lista.Count; i++)
            {
                Jurado j = lista[i];
                
                comboJurado.Items.Add(j);
            }
            
        }
    }
}
