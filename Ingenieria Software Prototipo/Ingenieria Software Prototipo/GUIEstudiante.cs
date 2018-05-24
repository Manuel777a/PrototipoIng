﻿using System;
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
        public string rutaP,rutaT;
        public GUIEstudiante(ProgramaAcademico pPrograma,Equipo pEquipo)   
        {
            InitializeComponent();
            programaAcademico = pPrograma;
            equipo = pEquipo;
            txtNom1.Text = equipo.darEstudiantes[0].ToString();
            txtNom2.Text = equipo.darEstudiantes[1].ToString();
            txtNom3.Text = equipo.darEstudiantes[2].ToString();
            txtNom4.Text = equipo.darEstudiantes[3].ToString();
            cargarPropuesta();
            cargarTrabajo();
        }
        public void cargarPropuesta()
        {
            Propuesta p = equipo.darPropuesta();
            if(p==null)
            {
                textBoxRuta.ReadOnly = false;
                textBoxTitulo.ReadOnly = false;
                dtpFechaEntrega.Enabled = true;              
            }
            else
            {
                textBoxRuta.Text = p.darRutaDocumento;
                textBoxTitulo.Text = p.darTitulo;
                comboBoxCalificacion.SelectedItem = p.darCalificacion;
                comboBoxModalidad.SelectedItem = p.darModalidad;
                rutaP = p.darRutaDocumento;
                 //dtpFechaEntrega.Value = p.darFechaEntrega;
                axAcroPDF1.LoadFile(rutaP);
            }
        }

        public void cargarTrabajo()
        {
            
            //TrabajoDeGrado t = equipo.darTrabajoDeGrado();
            //txtTitTrabajoGrado.Text = textBoxTitulo.Text;
            //cmbModalidadTra.SelectedItem = comboBoxModalidad;
            ////cmbCalTra.SelectedItem = t.darCalificacion();
            //rutaT = t.darRuta();
            //axAcroPDF2.LoadFile(rutaT);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            object modalidad = comboBoxModalidad.SelectedItem;
            if (textBoxRuta.Text.Equals("")||textBoxTitulo.Text.Equals("")||modalidad==null )
            {
                MessageBox.Show("No ingresado todos los datos necesarios para crear subir una propuesta de grado");
            }
            else
            {
                string ruta = textBoxRuta.Text;
                string titulo = textBoxTitulo.Text;
                string modalidadd = (string)comboBoxModalidad.SelectedItem;
                Propuesta p = new Propuesta(titulo, modalidadd, ruta);
                equipo.asignarPropuestaDeGrado(p);
                cargarPropuesta();
            }
        }

        

        private void btnExaminarT_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos txt (*.pdf) | *.pdf";
            abrir.Title = "Seleccione isométrico";
            abrir.RestoreDirectory = true;

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                rutaT = abrir.FileName;
                txtRutaATrabajo.Text = rutaT;
            }
            else
            {
                MessageBox.Show("No selecciono la ruta");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void buttonExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos txt (*.pdf) | *.pdf";
            abrir.Title = "Seleccione isométrico";
            abrir.RestoreDirectory = true;

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                rutaP = abrir.FileName;
                textBoxRuta.Text = rutaP;
            }
            else
            {
                MessageBox.Show("No selecciono la ruta");
            }
        }

        
    }
}
