using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiServis
{
    class StavkaUgovora
    {
        public int ID_stavke { get; set; }
        public int ID_ugovora { get; set; }
        public string VrstaRada { get; set; }
        public int BrojSati { get; set; }
        public double Cijena { get; set; }
        public double Ukupno { get; set; }
    }
}
