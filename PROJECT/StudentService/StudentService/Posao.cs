using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiServis
{
    class Posao
    {
        public int ID_posla { get; set; }
        public int ID_grupe { get; set; }
        public string VrstaPosla { get; set; }
        public string Opis { get; set; }
        public string MjestoObavljanja { get; set; }
        public double Satnica { get; set; }
        public string GrupaPosla { get; set; }
    }
}
