﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.Users
{
    public class UpdateModel
    {
        public string Identificacion { get; set; }
        public string NombreCompleto { get; set; }
        public string CorreoElectronico { get; set; }
        public string NumeroTelefono { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Estado { get; set; }
    }
}
