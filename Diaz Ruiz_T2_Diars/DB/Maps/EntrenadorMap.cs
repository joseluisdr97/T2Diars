using Diaz_Ruiz_T2_Diars.Clases;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Diaz_Ruiz_T2_Diars.DB.Maps
{
    public class EntrenadorMap:EntityTypeConfiguration<Entrenador>
    {
        public EntrenadorMap()
        {
            ToTable("Entrenador");
            HasKey(o => o.IdEntrenador);
        }
    }
}