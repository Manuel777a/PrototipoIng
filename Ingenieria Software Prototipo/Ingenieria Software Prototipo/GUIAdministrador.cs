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
            cbModalidadPropuesta.Enabled = false;
            cbModalidadTrabajo.Enabled = false;
        }

        private void btnConsultarPropuesta_Click(object sender, EventArgs e)
        {

            if (txtCodigoEst.Text.Equals("") || txtCodigoEst.Text == null)
            {
                MessageBox.Show("ERROR. Ingrese el código del estudiante");
            }

            Equipo equipo = programaAcademico.buscarEquipo(txtCodigoEst.Text);
            Propuesta propuesta = equipo.darPropuesta();
            if(propuesta!=null)
            {
                txtTituloPropuesta.Text = propuesta.darTitulo;
                txtRutaPropuesta.Text = propuesta.darRutaDocumento;
                txtObservacionesPropuesta.Text = propuesta.darObservaciones;
                cbCalificacionPropuesta.SelectedItem = propuesta.darCalificacion;
                cbModalidadPropuesta.SelectedItem = propuesta.darModalidad;
                 dtpFechaEntregaPropuesta.Value = propuesta.darFechaEntrega;
            }
            else
            {
                MessageBox.Show("El Estudiante no ha subido ninguna propuesta");
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
                txtTituloTrabajo.Text = trabajo.darTitulo();
                txtRutaTrabajo.Text = trabajo.darRuta();
                txtObservacionesTrabajo.Text = trabajo.darObservaciones();
                cbModalidadTrabajo.SelectedItem = trabajo.darModalidad();
                cbCalificacionTrabajo.SelectedItem = trabajo.darCalificacion();
               // dtpTrabajo.Value = trabajo.darFechaEntrega();
            }

        }

        private void btnAsignarJurado_Click(object sender, EventArgs e)
        {

            //if (txtCodigoEst.Text.Equals("") || txtCodigoEst.Text == null)
            //{
            //    MessageBox.Show("ERROR. Ingrese el código del estudiante");
            //    return;
            //}

            //if( comboJurado.SelectedItem == null && (txtCodigoJurado1.Text ==null && txtCodigoJurado1.Text.Equals("")))
            //{
            //    MessageBox.Show("ERROR. Debe escoger un jurado");
            //    return;
            //}

            Equipo equipo = programaAcademico.buscarEquipo(txtCodigoEst.Text);
            TrabajoDeGrado trabajo = equipo.darTrabajoDeGrado();
            if (trabajo == null)
            {
                MessageBox.Show("ERROR. El equipo no tiene un trabajo de grado en el sistema.");
                return;

            }
            
            if (comboJurado.SelectedItem != null)
            {
                Jurado jurado = (Jurado)comboJurado.SelectedItem;
                jurado.agregarTrabajoGrado(trabajo);
                MessageBox.Show("Se ha asignado el trabajo de grado: " + trabajo.darTitulo() + " Al jurado: " + jurado.darNombre());
                return;
            }
            if (txtCodigoJurado1.Text != null || !txtNombreJurado1.Text.Equals(""))
            {
                Jurado juradoNuevo = new Jurado(txtNombreJurado1.Text, txtCodigoJurado1.Text);
                programaAcademico.agregarJurado(juradoNuevo);
                juradoNuevo.agregarTrabajoGrado(trabajo);
                llenarCombo();
            }
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

        private void btnActualizarPropuesta_Click(object sender, EventArgs e)
        {

            if (txtCodigoEst.Text.Equals("") || txtCodigoEst.Text == null)
            {
                MessageBox.Show("ERROR. Ingrese el código del estudiante");
                return;
            }
            
            Equipo equipo = programaAcademico.buscarEquipo(txtCodigoEst.Text);
            Propuesta propuesta = equipo.darPropuesta();

            propuesta.darCalificacion = cbCalificacionPropuesta.Text;
            propuesta.darFechaEntrega = dtpFechaEntregaPropuesta.Value;
            propuesta.darObservaciones = txtObservacionesPropuesta.Text;
           
            MessageBox.Show("Propuesta modificada correctamente.");

        }

        private void btnActualizarTrabajo_Click(object sender, EventArgs e)
        {
            if (txtCodigoEst.Text.Equals("") || txtCodigoEst.Text == null)
            {
                MessageBox.Show("ERROR. Ingrese el código del estudiante");
                return;
            }

            else if (comboJurado.SelectedItem == null)
            {
                MessageBox.Show("ERROR. Debe escoger un jurado");
                return;
            }

            Equipo equipo = programaAcademico.buscarEquipo(txtCodigoEst.Text);
            TrabajoDeGrado trabajo = equipo.darTrabajoDeGrado();

            trabajo.cambiarCalificacion(cbCalificacionTrabajo.Text);
            trabajo.cambiarObservaciones(txtObservacionesTrabajo.Text);
            trabajo.cambiarFechaEntrega(dtpTrabajo.Value);

            MessageBox.Show("Trabajo de grado modificado exitosamente.");
            
        }

        private void GUIAdministrador_Load(object sender, EventArgs e)
        {

        }
    }
}
