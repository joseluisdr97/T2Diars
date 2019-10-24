using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diaz_Ruiz_T2_Diars.Clases
{
    public class Pokemon
    {
        public int IdPokemon { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }

        public List<Captura> Capturas { get; set; }
    }
}