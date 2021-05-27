using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_Duombaziu.Models
{
    class Kurjeris
    {
        public int kurjerio_id { get; set; }
        public string vardas { get; set; }
        public string pavarde { get; set; }
        public string el_pastas { get; set; }
        public string tel_nr{ get; set; }
        public int transporto_id{ get; set; }

        public Kurjeris(int kurjerio_id, string vardas, string pavarde, string el_pastas, string tel_nr, int transporto_id)
        {
            this.kurjerio_id = kurjerio_id;
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.el_pastas = el_pastas;
            this.tel_nr = tel_nr;
            this.transporto_id = transporto_id;
        }
    }
}
