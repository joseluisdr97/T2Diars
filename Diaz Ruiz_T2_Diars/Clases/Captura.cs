using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diaz_Ruiz_T2_Diars.Clases
{
    public class Captura
    {
        public int IdCaptura { get; set; }
        public int IdPokemon { get; set; }
        public int IdEntrenador { get; set; }
        
        public Pokemon Pokemon { get; set; }
        public Entrenador Entrenador { get; set; }
    }
}