using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_Duombaziu.Models
{
   public class Pristatymas
    {
        public int pristatymo_id { get; set; }
        public string busena{ get; set; }
        public string nurodytas_adresas{ get; set; }
        public DateTime nurodytas_laikas{ get; set; }
        public int kurjerio_id{ get; set; }

        public Pristatymas(int pristatymo_id, string busena, string nurodytas_adresas, DateTime nurodytas_laikas, int kurjerio_id)
        {
            this.pristatymo_id = pristatymo_id;
            this.busena = busena;
            this.nurodytas_adresas = nurodytas_adresas;
            this.nurodytas_laikas = nurodytas_laikas;
            this.kurjerio_id = kurjerio_id;
        }
    }
}
