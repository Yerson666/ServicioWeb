﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.Curso.Entrada
{
    public class EliminarCurso : Dto.General.EntradaAPI
    {
        public int Codigo { get; set; }
    }
}
