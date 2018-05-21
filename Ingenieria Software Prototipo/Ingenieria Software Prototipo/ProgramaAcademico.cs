using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software_Prototipo
{
    class ProgramaAcademico
    {
        private List<Equipo> equipos;

        private List<Jurado> jurados;

        public ProgramaAcademico()
        {
            equipos = new List<Equipo>();
            jurados = new List<Jurado>(); 
        }

        public List<Equipo> darEquipos
        {
            get
            {
                return equipos;
            }
            set
            {
                equipos = value;
            }
        }

        public List<Jurado> darJurados
        {
            get
            {
                return jurados;
            }
            set
            {
                jurados = value;
            }
        }

        //terminar cuando se tenga la clase equipo
        public Equipo buscarEquipo(int codigoEstudiante)
        {
            return null;
        }

        //realizar el metodo buscarJurado

        public void agregarEquipo(Equipo equipo)
        {
            equipos.Add(equipo);
        }

    }
}
