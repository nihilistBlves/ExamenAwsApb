using ExamenAwsApb.Data;
using ExamenAwsApb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenAwsApb.Repositories {
    public class ApplicationRepository {
        private ApplicationContext context;
        public ApplicationRepository(ApplicationContext context) {
            this.context = context;
        }
        public List<Equipo> GetEquipos() {
            return this.context.Equipos.ToList();
        }
        public Equipo FindEquipo(int id) {
            return this.context.Equipos.SingleOrDefault(x => x.IdEquipo == id);
        }
        public List<Jugador> GetJugadoresByEquipo(int idequipo) {
            return this.context.Jugadores.Where(x => x.IdEquipo == idequipo).ToList();
        }
        public Jugador FindJugador(int id) {
            return this.context.Jugadores.SingleOrDefault(x => x.IdJugador == id);
        }
        public List<Apuesta> GetApuestas() {
            return this.context.Apuestas.ToList();
        }
        public void CreateJugador(Jugador jugador) {
            jugador.IdJugador = this.GetMaxIdJugador() + 1;
            this.context.Jugadores.Add(jugador);
            this.context.SaveChanges();
        }
        public void CreateApuesta(Apuesta apuesta) {
            apuesta.IdApuesta = this.GetMaxIdApuesta() + 1;
            this.context.Apuestas.Add(apuesta);
            this.context.SaveChanges();
        }
        private int GetMaxIdJugador() {
            if (this.context.Jugadores.Count() != 0) {
                return this.context.Jugadores.Max(x => x.IdJugador);
            } else {
                return 0;
            }
        }
        private int GetMaxIdApuesta() {
            if (this.context.Apuestas.Count() != 0) {
                return this.context.Apuestas.Max(x => x.IdApuesta);
            }
            else {
                return 0;
            }
        }
    }
}
