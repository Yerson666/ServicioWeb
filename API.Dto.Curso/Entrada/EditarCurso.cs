﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.Curso.Entrada
{
    public class EditarCurso : Dto.General.EntradaAPI
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Credito { get; set; }
        public string Horario { get; set; }
        public string Estado { get; set; }
    }
}
