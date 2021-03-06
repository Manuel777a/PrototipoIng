﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software_Prototipo
{
    public class ProgramaAcademico
    {
        private List<Equipo> equipos;

        private List<Jurado> jurados;

        public ProgramaAcademico()
        {
            equipos = new List<Equipo>();
            jurados = new List<Jurado>();

            Jurado j1 = new Jurado("j1", "1");

            jurados.Add(j1);
            Jurado j2 = new Jurado("j2", "2");

            jurados.Add(j2);
            Jurado j3 = new Jurado("j3", "3");

            jurados.Add(j3);


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
        public Equipo buscarEquipo(string codigoEstudiante)
        {
            Equipo result = null;
            bool encontro = false;
            for (int i = 0; i < equipos.Count && !encontro; i++)
            {
                Estudiante[] estudiantesEquipo = equipos[i].darEstudiantes;
                for(int j=0;j<estudiantesEquipo.Length;j++)
                {
                    if(estudiantesEquipo[j].darCodigo.Equals(codigoEstudiante))
                    {
                        result = equipos[i];
                        encontro = true;
                        break;
                    }
                }
            }
            return result;
        }

        //realizar el metodo buscarJurado
        public Jurado buscarJurado(String pCedula)
        {
            Jurado aux = null;
            for(int i=0;i < jurados.Count;i++)
            {
                if(jurados[i].darCedula().Equals(pCedula))
                {
                    aux = jurados[i];
                    break;
                }
            }
            return aux;
        }
        public void agregarEquipo(Equipo equipo)
        {
            equipos.Add(equipo);
        }
        public void agregarJurado(Jurado jurado)
        {
            jurados.Add(jurado);
        }
    }
}
