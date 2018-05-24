using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software_Prototipo
{
    public class TrabajoDeGrado
    {

        private String titulo, modalidad, observaciones, calificacion, rutaDocumento;

        private DateTime fechaEntrega;

        //Crear una lista de jurados o dejar un solo jurado?
        //private Jurado[] jurados;

        public enum CalificacionesT
        {
                Laureado,
                Meritoria,
                Aprobado,
                DevueltaParaCorrecciones
        }

        public TrabajoDeGrado(String pTitulo, String pModalidad, String pRutaDocumento )
        {
            titulo = pTitulo;
            modalidad = pModalidad;
            rutaDocumento = pRutaDocumento;
        //    jurados = new Jurado[2];

        }
        //public void asignarJurado(Jurado pJurado1,Jurado pJurado2)
        //{
        //    jurados[0] = pJurado1;
        //    jurados[1] = pJurado2;
        //}
        public String darTitulo()
        {
            return titulo;
        }
        public String darRuta()
        {
            return rutaDocumento;
        }   
        public String darModalidad()
        {
            return modalidad;
        }

        public DateTime darFechaEntrega()
        {
            return fechaEntrega;
        }

        public void cambiarFechaEntrega(DateTime pFecha)
        {
            fechaEntrega = pFecha;
        }

        public void asignarTiempoEntrega(DateTime tiempo)
        {
            fechaEntrega = tiempo;
        }

        public void cambiarRutaDocument(String pRuta)
        {
            rutaDocumento = pRuta;
        }
        public void cambiarCalificacion(String cal)
        {
            calificacion = cal;
        }
        public String darCalificacion()
        {
            return calificacion;
        }

        public String darObservaciones()
        {
            return observaciones;
        }
        public void cambiarObservaciones(String pObservaciones)
        {
            observaciones = pObservaciones;
        }
    }
}
