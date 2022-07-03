using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.Users
{
    public class RegisterModel
    {
        [Required]
        public string NombreCompleto { get; set; }
        [Required]
        public string CorreoElectronico { get; set; }
        [Required]
        public string NumeroTelefono { get; set; }

        [Required]
        public string Identificacion { get; set; }

        [Required]
        public string Username { get; set; }



        [Required]
        public string Password { get; set; }
        [Required]
        public string Estado { get; set; }
    }
}
