using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software_Prototipo
{
    class Estudiante
    {
        private String nombre;

        private int codigo;

        public Estudiante(String nombre, int codigo)
        {
            this.nombre = nombre;
            this.codigo = codigo;
        }

        public String darNombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public int darCodigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }
    }
}

