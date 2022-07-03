using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.ModalidadCurso.Entrada
{
    public class AgregarModalidadCurso : Dto.General.EntradaAPI
    {

        public string TipoModal { get; set; }
        public string Duracion { get; set; }
        public string Grado { get; set; }
        public string NumModal { get; set; }


    }
}
