using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartU2.Models
{
    public class Zona
    {
        [Key]
        public int IdZona { set; get; }
        public string Nombre { set; get; }
        public int Capacidad { set; get; }
        public string ruta { set; get; }
    }
}
