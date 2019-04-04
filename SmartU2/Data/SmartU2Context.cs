using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartU2.Models;

namespace SmartU2.Models
{
    public class SmartU2Context : DbContext
    {
        /*
         * clase que se encarga de realizar la conexion con la base de datos
         * utilizando los modelos para conectarlos con la base de datos
         */
        public SmartU2Context (DbContextOptions<SmartU2Context> options)
            : base(options)
        {
        }

        public DbSet<SmartU2.Models.Zona> Zona { get; set; }

        public DbSet<SmartU2.Models.SlotParqueadero> SlotParqueadero { get; set; }

        public DbSet<SmartU2.Models.Usuario> Usuario { get; set; }

        public DbSet<SmartU2.Models.Vehiculo> Vehiculo { get; set; }
    }
}
