using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.ModalidadCurso.Salida
{
    public class VerTodosModalidadCursos : Dto.General.RespuestaAPI
    {
        //Se crea una lista de colllections

        public List<DatosModalidadCurso> ListaModalidadCursos { get; set; }

        //Se crea un constructor donde asginamos una nueva lista, esta lista contiene los objetos Modalidad Cursos
        public VerTodosModalidadCursos()
        {
            ListaModalidadCursos = new List<DatosModalidadCurso>();
        }

        public void setErrorComunicacion(string v)
        {
            throw new NotImplementedException();
        }
    }

    public class DatosModalidadCurso
    {
        public int Codigo { get; set; }
        public string TipoModal { get; set; }
        public string Duracion { get; set; }
        public string Grado { get; set; }
        public string NumModal { get; set; }


    }
}
