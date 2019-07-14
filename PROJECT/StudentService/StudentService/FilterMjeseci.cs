using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiServis
{
    class FilterMjeseci
    {
        public string IDMjeseca { get; set; }
        public string NazivMjeseca { get; set; }

        public FilterMjeseci(string ID, string naziv)
        {
            this.IDMjeseca = ID;
            this.NazivMjeseca = naziv;
        }
    }
}
