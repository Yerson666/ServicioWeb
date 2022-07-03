using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.Departamento.Salida
{
    public class VerDetalleDepartamento : Dto.General.RespuestaAPI
    {


           public int Codigo { get; set; }
            public string Nombre { get; set; }
            public string Presupuesto { get; set; }
            public string NumNomina { get; set; }
            public string Estado { get; set; }
    }
}
