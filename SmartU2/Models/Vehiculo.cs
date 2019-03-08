using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartU2.Models
{
    public class Vehiculo
    {
        [Key]
        public int idVehiculo { set; get; }
        public string placa { set; get; }
        public DateTime fechaHora_entrada { set; get; }
        public DateTime fechaHora_salida { set; get; }
    }
}
