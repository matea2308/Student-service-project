using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiServis
{
    class Student
    {
        public int ID_studenta { get; set; }
        public int ID_spreme { get; set; }
        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Adresa { get; set; }
        public string BrojIskaznice { get; set; }
        public string ImeIPrezime { get; set; }
        public string StrucnaSprema { get; set; }
    }
}
