using Diaz_Ruiz_T2_Diars.Clases;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Diaz_Ruiz_T2_Diars.DB.Maps
{
    public class CapturaMap : EntityTypeConfiguration<Captura>
    {
        public CapturaMap()
        {
            ToTable("Captura");
            HasKey(o => o.IdCaptura);

            HasRequired(o => o.Pokemon)
           .WithMany(o => o.Capturas)
           .HasForeignKey(o => o.IdPokemon);

            HasRequired(o => o.Entrenador)
         .WithMany(o => o.Capturas)
         .HasForeignKey(o => o.IdEntrenador);
        }
    }
}