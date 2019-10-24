using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diaz_Ruiz_T2_Diars.Clases
{
    public class Entrenador
    {
        public int IdEntrenador { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }

        public List<Captura> Capturas { get; set; }
    }
}