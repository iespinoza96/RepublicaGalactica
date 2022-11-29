using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Maestro
    {
        //public int IdMaestro { get; set; }

        public ML.OrdenJedi OrdenJedi { get; set; }

        public ML.SistemasAmenazados SistemasAmenazados { get; set; }

        public bool Rango { get; set; }

        public List<object> Maestros { get; set; }

        public string NombreCaballero { get; set; }

        //public bool Rango { get; set; }

        public string Combate { get; set; }
    }
}
