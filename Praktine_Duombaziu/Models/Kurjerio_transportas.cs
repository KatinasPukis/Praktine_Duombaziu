using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_Duombaziu.Models
{
    class Kurjerio_transportas
    {
        public int id { get; set; }
        public int kurjerio_id { get; set; }
        public int uzsakymo_id { get; set; }
        public int transporto_id { get; set; }
        public DateTime date { get; set; }

        public Kurjerio_transportas(int id, int kurjerio_id, int uzsakymo_id, int transporto_id, DateTime date)
        {
            this.id = id;
            this.kurjerio_id = kurjerio_id;
            this.uzsakymo_id = uzsakymo_id;
            this.transporto_id = transporto_id;
            this.date = date;
        }
    }
}
