using Diaz_Ruiz_T2_Diars.Clases;
using Diaz_Ruiz_T2_Diars.DB.Maps;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Diaz_Ruiz_T2_Diars.DB
{
    public class AppConexionDB:DbContext
    {
        public IDbSet<Entrenador> Entrenadores { get; set; }
        public IDbSet<Pokemon> Pokemones { get; set; }
        public IDbSet<Captura> Capturas { get; set; }
        public AppConexionDB()
        {
            Database.SetInitializer<AppConexionDB>(null);//Cuando añada tablas va haber problemas de referencia
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new EntrenadorMap());
            modelBuilder.Configurations.Add(new PokemonMap());
            modelBuilder.Configurations.Add(new CapturaMap());
        }
    }
}