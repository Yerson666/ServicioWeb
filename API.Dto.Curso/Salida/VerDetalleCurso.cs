using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.Curso.Salida
{
    public class VerDetalleCurso : Dto.General.RespuestaAPI 
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Credito { get; set; }
        public string Horario { get; set; }
        public string Estado { get; set; }
    }
}
