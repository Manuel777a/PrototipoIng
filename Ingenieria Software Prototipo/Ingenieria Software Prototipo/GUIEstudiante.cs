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
            cargar();
            comboBoxCalificacion.Enabled = false;
            cmbCalTra.Enabled = false;            
        }
        public void cargar()
        {
            Propuesta p = equipo.darPropuesta();
            if(p==null)
            {
                textBoxRuta.ReadOnly = false;
                textBoxTitulo.ReadOnly = false;                            
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
                txtTitTrabajoGrado.Text = p.darTitulo;
                cmbModalidadTra.SelectedItem = p.darModalidad;
                cmbModalidadTra.Enabled = false;
                comboBoxModalidad.Enabled = false;
                btnSubirPropuesta.Enabled = false;
                textBoxProp.Text = p.darObservaciones;
            }
            TrabajoDeGrado t = equipo.darTrabajoDeGrado();
            if(t!=null)
            {
                axAcroPDF2.LoadFile(t.darRuta());
                cmbModalidadTra.SelectedItem = t.darModalidad();
                cmbCalTra.SelectedItem = t.darCalificacion();
                textBoxTrabajo.Text = t.darObservaciones();
            }                      
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
                cargar();
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

        

        private void button2_Click(object sender, EventArgs e)
        {
            btnSubirPropuesta.Enabled = true;
            textBoxTitulo.ReadOnly = false;
            comboBoxModalidad.Enabled = true;
        }

        private void btnSubirTrabajo_Click(object sender, EventArgs e)
        {
            try
            {
                    string ruta = txtRutaATrabajo.Text;
                    string titulo = txtTitTrabajoGrado.Text;
                    string modalidad = (string)cmbModalidadTra.SelectedItem;
                    TrabajoDeGrado t = new TrabajoDeGrado(titulo, modalidad, ruta);
                    equipo.setTrabajoDeGrado(t);
                    axAcroPDF2.LoadFile(ruta);                              
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
           
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
