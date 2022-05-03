using ExamenAwsApb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenAwsApb.Data {
    public class ApplicationContext: DbContext {
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options) { }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Apuesta> Apuestas { get; set; }
    }
}
