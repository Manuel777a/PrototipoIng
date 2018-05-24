using
     System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software_Prototipo
{
    class Jurado
    {
        private String nombre;
        private String cedula;
        private List<TrabajoDeGrado> TrabajosDeGrado;
        public Jurado(String pNombre, String pCedula)
        {
            nombre = pNombre;
            cedula = pCedula;
            TrabajosDeGrado = new List<TrabajoDeGrado>();
        }
        public String darNombre()
        {
            return nombre;
        }
        public String darCedula()
        {
            return cedula;
        }

        public void agregarTrabajoGrado(TrabajoDeGrado pTrabajo)
        {
            TrabajosDeGrado.Add(pTrabajo);
        }
        public List<TrabajoDeGrado> darTrabajosDeGrado()
        {
            return TrabajosDeGrado;
        }        
    }
}
