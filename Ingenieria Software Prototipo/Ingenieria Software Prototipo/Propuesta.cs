using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software_Prototipo
{
    public class Propuesta
    {

        public enum Modalidades
        {
            Monografía,
            AsistenciaDeInvestigación,
            TrabajoDeInvestigación,
            OpciónEmprendimiento
        }

        public enum Calificaciones
        {
            Aprobada,
            DevueltaParaCorreciones,
            NoAceptada,
            PorRevisar
            
        }

        private String titulo, modalidad,observaciones,calificacion,rutaDocumento;

        private DateTime fechaEntrega;

        public Propuesta(String titulo, String modalidad, String rutaDocumento)
        {
            this.titulo = titulo;
            this.modalidad = modalidad;
            this.rutaDocumento = rutaDocumento;
            calificacion = Propuesta.Calificaciones.PorRevisar.ToString();
        }

        public String darTitulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }

        public String darModalidad
        {
            get
            {
                return modalidad;
            }
            set
            {
                modalidad = value;
            }
        }

        public DateTime darFechaEntrega
        {
            get
            {
                return fechaEntrega;
            }
            set
            {
                fechaEntrega = value;
            }
        }

        public String darCalificacion
        {
            get
            {
                return calificacion;
            }
            set
            {
                calificacion = value;
            }
        }

        public String darObservaciones
        {
            get
            {
                return observaciones;
            }
            set
            {
                observaciones = value;
            }
        }

        public String darRutaDocumento
        {
            get
            {
                return rutaDocumento;
            }
            set
            {
                rutaDocumento = value;
            }
        }
    }
}
