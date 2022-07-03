using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.Departamento.Salida
{
    public class VerTodosDepartamentos : Dto.General.RespuestaAPI
    {
        //Se crea una lista de colllections

        public List<DatosDepartamento> ListaDepartamentos { get; set; }

        //Se crea un constructor donde asginamos una nueva lista, esta lista contiene los objetos departamento.
        public VerTodosDepartamentos()
        {
            ListaDepartamentos = new List<DatosDepartamento>();
        }

        public void setErrorComunicacion(string v)
        {
            throw new NotImplementedException();
        }
    }

    public class DatosDepartamento
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Presupuesto { get; set; }
        public string NumNomina { get; set; }
        public string Estado { get; set; }

    }
}
