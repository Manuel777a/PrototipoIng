using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software_Prototipo
{
   public  class Estudiante
    {
        private String nombre;

        private string codigo;

        public Estudiante(String nombre, string codigo)
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

        public string darCodigo
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
        public override String ToString()
        {
            return nombre;
        }
    }
}

