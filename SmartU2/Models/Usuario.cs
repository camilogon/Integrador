using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartU2.Models
{
    public class Usuario
    {
        [Key]
        public int Id { set; get; }
        public string Cedula { set; get; }
        public string Nombre { set; get; }
        public string Correo { set; get; }
        public string Contrasena { set; get; }
        public string Tipo { set; get; }
        public bool Estado { set; get; }
    }
}
