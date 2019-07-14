using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiServis
{
    class Ugovor
    {
        public int ID_ugovora { get; set; }
        public int ID_poslodavca { get; set; }
        public int ID_posla { get; set; }
        public int ID_studenta { get; set; }
        public NpgsqlRange<DateTime> Trajanje { get; set; }
        public string Poslodavac { get; set; }
        public string Posao { get; set; }
        public double Satnica { get; set; }
        public string Student { get; set; }
    }
}
