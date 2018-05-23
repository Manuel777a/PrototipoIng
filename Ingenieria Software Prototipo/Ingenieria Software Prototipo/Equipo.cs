using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software_Prototipo
{
    class Equipo
    {
        private bool estadoAlDia;
        private TrabajoDeGrado trabajoDeGrado;
        private Propuesta propuesta;
        private Estudiante[] estudiantes;

        public Equipo()
        {
            estudiantes = new Estudiante[4];
        }
        public Propuesta darPropuesta()
        {
            return propuesta;
        }

        public void asignarPropuestaDeGrado(Propuesta pPropuesta)
        {
            propuesta = pPropuesta;
        }

        public void cambiarEstadoAlDia()
        {
            estadoAlDia = !estadoAlDia;
        }
        public bool darEstadoAlDia()
        {
            return estadoAlDia;
        }
        public void setTrabajoDeGrado(TrabajoDeGrado tg)
        {
            trabajoDeGrado = tg;
        }

        public TrabajoDeGrado darTrabajoDeGrado()
        {
            return trabajoDeGrado;
        }

        public void setEstudiantes(Estudiante stud1, Estudiante stud2, Estudiante stud3, Estudiante stud4)
        {
            estudiantes[0] = stud1;
            estudiantes[1] = stud1;
            estudiantes[2] = stud1;
            estudiantes[3] = stud1;
        }


    }
}

