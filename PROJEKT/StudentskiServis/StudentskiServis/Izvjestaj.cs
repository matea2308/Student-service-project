using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiServis
{
    class Izvjestaj
    {
        public string NazivStudenta { get; set; }
        public string NazivPoslodavca { get; set; }
        public long? UkupnoSati { get; set; }
        public double? UkupnaCijena { get; set; }
        public double Mjesec { get; set; }
    }
}
