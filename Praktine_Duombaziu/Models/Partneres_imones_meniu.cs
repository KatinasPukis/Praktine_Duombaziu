using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_Duombaziu.Models
{
    public class Partneres_imones_meniu
    {
        public int id { get; set; }
        public string produkto_tipas { get; set; }
        public int produkto_kiekis { get; set; }
        public double produkto_kaina { get; set; }
        public int partneres_imones_id { get; set; }

        public Partneres_imones_meniu(int id, string produkto_tipas, int produkto_kiekis, double produkto_kaina, int partneres_imones_id)
        {
            this.id = id;
            this.produkto_tipas = produkto_tipas;
            this.produkto_kiekis = produkto_kiekis;
            this.produkto_kaina = produkto_kaina;
            this.partneres_imones_id = partneres_imones_id;
        }
    }
}
