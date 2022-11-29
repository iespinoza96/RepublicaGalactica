using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class SistemasAmenazados
    {
        public int IdSistemasAmenazados { get; set; }

        public ML.Sistema Sistema { get; set; }

        public bool Amenazado { get; set; }
    }
}
