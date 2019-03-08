using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartU2.Models
{
    public class SlotParqueadero
    {
        [Key]
        public int IdSlotParqueadero { set; get; }
        public bool Estado { set; get; }
        public string PuntoCardinalx { set; get; }
        public string PuntoCardinaly { set; get; }
        public string Placa { set; get; }
        [ForeignKey("Zona")]
        public int IdZona { set; get; }
    }
}
