using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_Duombaziu.Models
{
    class Partnere_imone
    {
        public int imones_id { get; set; }
        public string pavadinimas{ get; set; }
        public Partnere_imone(int imones_id, string pavadinimas)
        {
            this.imones_id = imones_id;
            this.pavadinimas = pavadinimas;
        }
    }
}
