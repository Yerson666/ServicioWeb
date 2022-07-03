using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.Profesor.Salida
{
    public class VerTodosProfesores : Dto.General.RespuestaAPI
    {

        //Se crea una lista de colllections

        public List<DatosProfesor> ListaProfesores { get; set; }

        //Se crea un constructor donde asginamos una nueva lista, esta lista contiene los objetos de estudiantes.
        public VerTodosProfesores()
        {
            ListaProfesores = new List<DatosProfesor>();
        }

        public void setErrorComunicacion(string v)
        {
            throw new NotImplementedException();
        }
    }

    public class DatosProfesor
    {
        public int Codigo { get; set; }
        public string Identificacion { get; set; }
        public string NombreCompleto { get; set; }
        public string CorreoElectronico { get; set; }
        public string Estado { get; set; }


    }








}

 