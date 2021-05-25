using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_Duombaziu.Models
{
    public class UzsakymoPreke
    {
        public int operacijosNr { get; set; }
        public int prekesId { get; set; }
        public int kiekis { get; set; }
        public double kaina { get; set; }
        public int partImonesMeniuId { get; set; }
        public int uzsakymoId { get; set; }

        public UzsakymoPreke(int operacijosNr, int prekesId, int kiekis, double kaina, int partImonesMeniuId, int uzsakymoId)
        {
            this.operacijosNr = operacijosNr;
            this.prekesId = prekesId;
            this.kiekis = kiekis;
            this.kaina = kaina;
            this.partImonesMeniuId = partImonesMeniuId;
            this.uzsakymoId = uzsakymoId;
        }
    }
}
