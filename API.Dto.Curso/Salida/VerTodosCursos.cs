using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.Curso.Salida
{
    public class VerTodosCursos : Dto.General.RespuestaAPI
    {
        //Se crea una lista de colllections

        public List<DatosCurso> ListaCursos { get; set; }

        //Se crea un constructor donde asginamos una nueva lista, esta lista contiene los objetos de estudiantes.
        public VerTodosCursos()
        {
            ListaCursos = new List<DatosCurso>();
        }

        public void setErrorComunicacion(string v)
        {
            throw new NotImplementedException();
        }

    }


    public class DatosCurso
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Credito { get; set; }
        public string Horario { get; set; }
        public string Estado { get; set; }


    }
}
